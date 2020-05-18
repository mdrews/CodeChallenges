/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

var inputs = readline().split(' ');
const w = parseInt(inputs[0]);
const h = parseInt(inputs[1]);
const n = parseInt(inputs[2]);

let map = [];
for (let i = 0; i < h; i++) {
    const line = readline();
    map = [...map, line];
}

// Write an answer using console.log()
// To debug: console.error('Debug messages...');

console.log(map);
