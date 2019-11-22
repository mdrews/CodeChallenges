/**
 * Bring data on patient samples from the diagnosis machine to the laboratory with enough molecules to produce medicine!
 **/

const projectCount = parseInt(readline());
for (let i = 0; i < projectCount; i++) {
    var inputs = readline().split(' ');
    const a = parseInt(inputs[0]);
    const b = parseInt(inputs[1]);
    const c = parseInt(inputs[2]);
    const d = parseInt(inputs[3]);
    const e = parseInt(inputs[4]);
}

// game loop
while (true) {
    for (let i = 0; i < 2; i++) {
        var inputs = readline().split(' ');
        const target = inputs[0];
        const eta = parseInt(inputs[1]);
        const score = parseInt(inputs[2]);
        const storageA = parseInt(inputs[3]);
        const storageB = parseInt(inputs[4]);
        const storageC = parseInt(inputs[5]);
        const storageD = parseInt(inputs[6]);
        const storageE = parseInt(inputs[7]);
        const expertiseA = parseInt(inputs[8]);
        const expertiseB = parseInt(inputs[9]);
        const expertiseC = parseInt(inputs[10]);
        const expertiseD = parseInt(inputs[11]);
        const expertiseE = parseInt(inputs[12]);
    }
    var inputs = readline().split(' ');
    const availableA = parseInt(inputs[0]);
    const availableB = parseInt(inputs[1]);
    const availableC = parseInt(inputs[2]);
    const availableD = parseInt(inputs[3]);
    const availableE = parseInt(inputs[4]);
    const sampleCount = parseInt(readline());
    for (let i = 0; i < sampleCount; i++) {
        var inputs = readline().split(' ');
        const sampleId = parseInt(inputs[0]);
        const carriedBy = parseInt(inputs[1]);
        const rank = parseInt(inputs[2]);
        const expertiseGain = inputs[3];
        const health = parseInt(inputs[4]);
        const costA = parseInt(inputs[5]);
        const costB = parseInt(inputs[6]);
        const costC = parseInt(inputs[7]);
        const costD = parseInt(inputs[8]);
        const costE = parseInt(inputs[9]);
    }
    console.log('test');

    // Write an action using console.log()
    // To debug: console.error('Debug messages...');

    console.log('GOTO DIAGNOSIS');
}