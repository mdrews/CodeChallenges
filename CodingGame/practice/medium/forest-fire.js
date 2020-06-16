// https://www.codingame.com/ide/puzzle/forest-fire

/**
 * Send your available units to put out those fires! Watch out for water supplies!
 **/

const L = parseInt(readline()); // Size of forest map
const water = parseInt(readline()); // Total amount of water available

// game loop
while (true) {
    const N = parseInt(readline()); // Amount of fires
    for (let i = 0; i < N; i++) {
        var inputs = readline().split(' ');
        const fireX = parseInt(inputs[0]); // X coordinate of fire
        const fireY = parseInt(inputs[1]); // Y coordinate of fire
    }

    // Write an action using console.log()
    // To debug: console.error('Debug messages...');


    // Write the vehicle first letter (C=Canadair, H=Helicopter, J=SmokeJumpers) followed by the coordinates separated by a space
    console.log('C 0 0');
}
