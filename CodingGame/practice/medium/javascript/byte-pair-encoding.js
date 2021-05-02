/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
const findCommonPairInString = (line) => {
    let sequences = new Map();
    let maxSequenceSize = 1;
    for (let i = 0; i < line.length-2; i++) {
        let substring = line.substring(i, i+2)
        if (sequences.has(substring)) {
            sequences.set(substring, sequences.get(substring) + 1);
            if(maxSequenceSize < sequences.get(substring)) {
                maxSequenceSize += 1;
            }
        } else {
            sequences.set(substring, 1);
        }
        if((line[i] === line[i+1]) && (line[i]=== line[i+2])) {
            i++;
        }
    }
    if(maxSequenceSize === 1) {
        return 1;
    }
    return [...sequences.entries()]
        .filter(({ 1 : v }) => v === maxSequenceSize)
        .map(([k]) => k)[0];
}

const replaceBytePair = (line, bytePair, nonTerminalCharacter) => {
    line = line.split(bytePair).join(nonTerminalCharacter);
    return line;
}

var inputs = readline().split(' ');
const n = parseInt(inputs[0]);
const m = parseInt(inputs[1]);
let nonTerminalCharacter = 'Z';
let nonTerminalConversion = [];
let line = '';
for (let i = 0; i < n; i++) {
    line += readline();
}

var bytePair = findCommonPairInString(line);
while(bytePair != 1) {
    line = replaceBytePair(line, bytePair, nonTerminalCharacter);
    nonTerminalConversion.push(`${nonTerminalCharacter} = ${bytePair}`);
    nonTerminalCharacter = String.fromCharCode(nonTerminalCharacter.charCodeAt() - 1);
    bytePair = findCommonPairInString(line);
}

console.log(line);
nonTerminalConversion.forEach(key => {
    console.log(key);
});
