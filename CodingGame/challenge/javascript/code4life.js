/**
 * Bring data on patient samples from the diagnosis machine to the laboratory with enough molecules to produce medicine!
 **/
var location = -1;
const projectCount = parseInt(readline());
for (let i = 0; i < projectCount; i++) {
    var inputs = readline().split(' ');
    const a = parseInt(inputs[0]);
    const b = parseInt(inputs[1]);
    const c = parseInt(inputs[2]);
    const d = parseInt(inputs[3]);
    const e = parseInt(inputs[4]);
}

const commands = {
  diagnosis: "GOTO DIAGNOSIS",
  connect: "CONNECT"
}

const doAction = (state) => {
  switch(location) {
    case 0:
      console.log('CONNECT 5');
      location++;
    default:
      console.log('GOTO DIAGNOSIS');
      location++;
      break;
  }
}

// game loop
while (true) {
  var state = {};
    for (let i = 0; i < 2; i++) {
        var inputs = readline().split(' ');
        state = {
          target: inputs[0],
          eta: parseInt(inputs[1]),
          score: parseInt(inputs[2]),
          storage: [parseInt(inputs[3]), parseInt(inputs[4]), parseInt(inputs[5]), parseInt(inputs[6]), parseInt(inputs[7])],
          expertise: [parseInt(inputs[8]), parseInt(inputs[9]), parseInt(inputs[10]), parseInt(inputs[11]), parseInt(inputs[12])]};
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
    console.error(state);
    doAction();
    //console.log(commands.connect);
}