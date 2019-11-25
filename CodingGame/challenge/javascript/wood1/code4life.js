/**
 * Bring data on patient samples from the diagnosis machine to the laboratory with enough molecules to produce medicine!
 **/
const MAX_SAMPLES = 3;
const SAMPLES = 'SAMPLES';
const DIAGNOSIS = 'DIAGNOSIS';
const MOLECULES = 'MOLECULES';
const LABORATORY = 'LABORATORY';

var currentLocation = 'START';
var currentSample = {};
var mySamples = [];
var sampleCount = 0;
var diagnosedSamples = 0;

const projectCount = parseInt(readline());
for (let i = 0; i < projectCount; i++) {
    var inputs = readline().split(' ');
    const a = parseInt(inputs[0]);
    const b = parseInt(inputs[1]);
    const c = parseInt(inputs[2]);
    const d = parseInt(inputs[3]);
    const e = parseInt(inputs[4]);
}

const pickSample = () => {
  const availableSamples = state.samples.filter(sample => sample.carriedBy == -1);
  availableSamples.sort((sampleA, sampleB) => sampleB.health - sampleA.health);
  currentSample = availableSamples[0];
}

const getMolecules = () => {
  console.error(mySamples[0].cost);
  console.error(state.player.storage);
  if(state.player.storage[0] < parseInt(mySamples[0].cost[0])) {
    console.error(`${state.player.storage[0]} < ${mySamples[0].cost[0]}`);
    console.log('CONNECT A');
  } else if(state.player.storage[1] < parseInt(mySamples[0].cost[1])) {
    console.error(`${state.player.storage[0]} < ${mySamples[0].cost[0]}`);
    console.log('CONNECT B');
  } else if(state.player.storage[2] < parseInt(mySamples[0].cost[2])) {
    console.error(`${state.player.storage[0]} < ${mySamples[0].cost[0]}`);
    console.log('CONNECT C');
  } else if(state.player.storage[3] < parseInt(mySamples[0].cost[3])) {
    console.error(`${state.player.storage[0]} < ${mySamples[0].cost[0]}`);
    console.log('CONNECT D');
  } else if(state.player.storage[4] < parseInt(mySamples[0].cost[4])) {
    console.error(`${state.player.storage[0]} < ${mySamples[0].cost[0]}`);
    console.log('CONNECT E');
  } else {
    console.error('===TO LAB===');
    currentLocation = LABORATORY;
    console.log('GOTO LABORATORY');
  }
}

const doAction = (state) => {
  switch(currentLocation) {
    case SAMPLES:
      if(sampleCount++ < MAX_SAMPLES) {
        console.log('CONNECT 2');
      } else {
        console.log('GOTO DIAGNOSIS');
        currentLocation = DIAGNOSIS;
      }
      break;
    case DIAGNOSIS:
      if(diagnosedSamples++ < 3) {
        console.log(`CONNECT ${mySamples[0].sampleID}`);
      } else {
        currentLocation = MOLECULES;
        console.log('GOTO MOLECULES');
      }
      break;
    case MOLECULES:
      getMolecules();
      break;
    case LABORATORY:
      console.log(`CONNECT ${mySamples[0].sampleID}`);
      if(mySamples.length > 0) {
        currentLocation = MOLECULES;
        console.log('GOTO MOLECULES');
      } else {
        currentLocation = SAMPLES;
        console.log('GOTO SAMPLES');
      }
      break;
    default:
      console.log('GOTO SAMPLES');
      currentLocation = SAMPLES;
      break;
  }
}

// game loop
while (true) {
  var state = {};
    for (let i = 0; i < 2; i++) {
        var inputs = readline().split(' ');
        player = i === 0 ? 'player' : 'computer';
        state = {...state, 
          [player]: {
          target: inputs[0],
          eta: parseInt(inputs[1]),
          score: parseInt(inputs[2]),
          storage: [parseInt(inputs[3]), parseInt(inputs[4]), parseInt(inputs[5]), parseInt(inputs[6]), parseInt(inputs[7])],
          expertise: [parseInt(inputs[8]), parseInt(inputs[9]), parseInt(inputs[10]), parseInt(inputs[11]), parseInt(inputs[12])]}
        };
      }
    var inputs = readline().split(' ');
    state = {...state, available: [parseInt(inputs[0]), parseInt(inputs[1]), parseInt(inputs[2]), parseInt(inputs[3]), parseInt(inputs[4])] }
    const sampleCount = parseInt(readline());
    state = {...state, samples: []};
    for (let i = 0; i < sampleCount; i++) {
        var inputs = readline().split(' ');
        state = {...state, samples: [...state.samples, 
          { sampleID: parseInt(inputs[0]),
            carriedBy: parseInt(inputs[1]),
            rank: parseInt(inputs[2]),
            //expertiseGain = inputs[3],
            health: parseInt(inputs[4]),
            cost: [parseInt(inputs[5]), parseInt(inputs[6]), parseInt(inputs[7]), parseInt(inputs[8]), parseInt(inputs[9])],
            totalCost: parseInt(inputs[5]) + parseInt(inputs[6]) + parseInt(inputs[7]) + parseInt(inputs[8]) + parseInt(inputs[9])
          }]}
    }

    mySamples = state.samples
      .filter(sample => sample.carriedBy === 0)
      .sort((sampleA, sampleB) => sampleA.totalCost - sampleB.totalCost);
    
    // console.error(state);
    console.error(mySamples);

    doAction(state);
}