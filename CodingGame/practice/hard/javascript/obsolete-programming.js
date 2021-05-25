/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/

 const evaluateOperation = (operation, stack) => {
  // console.error(`instruction: ${instruction}`);
  let a = 0;
  let b = 0;
  switch(operation) {
      case 'ADD':
          a = stack.pop();
          b = stack.pop();
          stack.push(a + b);
          break;
      case 'SUB':
          b = stack.pop();
          a = stack.pop();
          stack.push(a - b);
          break;
      case 'MUL':
          b = stack.pop();
          a = stack.pop();
          stack.push(a * b);
          break;
      case 'DIV':
          b = stack.pop();
          a = stack.pop();
          stack.push((a / b).toFixed(0));
          break;
      case 'MOD':
          b = stack.pop();
          a = stack.pop();
          stack.push(a % b);
          break;
      case 'OUT':
          a = stack.pop();
          console.log(a);
          break;
      case 'POP':
          a = stack.pop();
          break;
      case 'DUP':
          a = stack.push(stack[stack.length-1]);
          break;
      case 'SWP':
          a = stack.pop();
          b = stack.pop();
          stack.push(a, b);
          break;
      case 'ROT':
          a = stack.splice(stack.length-3, 1);
          stack.push(a[0]);
          break;
      case 'OVR':
          stack.push(stack[stack.length-2]);
          break;
      default:
          console.error(`UNKNOWN: ${operation}`);
  }
  return stack;
}

const N = parseInt(readline());
let stack = [];
for (let i = 0; i < N; i++) {
  const line = readline();

  //console.error(line);
  let parseLine = line.split(' ');
  stack = [];
  parseLine.forEach(instruction => {
      if(isNaN(instruction)) {
          stack.push(parseInt(instruction));
      } else {
        stack = evaluateOperation(instruction, stack);
      }
  })
}
