/**
 * This code automatically collects game data in an infinite loop.
 * It uses the standard input to place data into the game variables such as x and y.
 * YOU DO NOT NEED TO MODIFY THE INITIALIZATION OF THE GAME VARIABLES.
 **/


// game loop
while (true) {
  var inputs = readline().split(' ');
  const x = parseInt(inputs[0]); // x position of your pod
  const y = parseInt(inputs[1]); // y position of your pod
  const nextCheckpointX = parseInt(inputs[2]); // x position of the next check point
  const nextCheckpointY = parseInt(inputs[3]); // y position of the next check point

  // Write an action using console.log()
  // To debug: console.error('Debug messages...');


  // Edit this line to output the target position
  // and thrust (0 <= thrust <= 100)
  // i.e.: "x y thrust"
  console.log(nextCheckpointX + ' ' + nextCheckpointY + ' 70');


}
