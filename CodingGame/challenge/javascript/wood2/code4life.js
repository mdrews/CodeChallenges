/**
 * Bring data on patient samples from the diagnosis machine to the laboratory with enough molecules to produce medicine!
 **/
var location = -1;
var currentSample = {}
const projectCount = parseInt(readline());
for (let i = 0; i < projectCount; i++) {
    var inputs = readline().split(' ');
    const a = parseInt(inputs[0]);
    const b = parseInt(inputs[1]);
    const c = parseInt(inputs[2]);
    const d = parseInt(inputs[3]);
    const e = parseInt(inputs[4]);
}

const pickSample = samples => {
  const availableSamples = samples.filter(sample => sample.carriedBy == -1);
  availableSamples.sort((sampleA, sampleB) => sampleB.health - sampleA.health);
  currentSample = availableSamples[0];
  return(availableSamples[0]);
}
""
const getMolecules = () => {
  if(currentSample.cost[0] > state.player.storage[0]) {
    console.log('CONNECT A');
  } else if(currentSample.cost[1] > state.player.storage[1]) {
    console.log('CONNECT B');
  } else if(currentSample.cost[2] > state.player.storage[2]) {
    console.log('CONNECT C');
  } else if(currentSample.cost[3] > state.player.storage[3]) {
    console.log('CONNECT D');
  } else if(currentSample.cost[4] > state.player.storage[4]) {
    console.log('CONNECT E');
  } else {
    location++;
    console.log('GOTO LABORATORY');
  }
}

const doAction = (state) => {
  console.log('REDUCER');
  switch(location) {
    case 0:
      const sample = pickSample(state.samples);
      console.log(`CONNECT ${currentSample.sampleID}`);
      location++;
      break;
    case 1:
      console.log('GOTO MOLECULES');
      location++;
      break;
    case 2:
      console.log('GET MOLECULES');
      getMolecules();
      break;
    case 3:
      console.log(`CONNECT ${currentSample.sampleID}`);
      location++;
      break;
    default:
      console.log('GOTO DIAGNOSIS');
      location = 0;
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
            cost: [parseInt(inputs[5]), parseInt(inputs[6]), parseInt(inputs[7]), parseInt(inputs[8]), parseInt(inputs[9])]
          }]}
    }
    console.error(currentSample);
    console.error(`location: ${location}`);
    console.error(state.player);
    doAction(state);
}