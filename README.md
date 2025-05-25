**Robot Hoover Cleaner**

This is a simple program that controls a bunch of robot hoovers cleaning a rectangular room. Each hoover starts somewhere on the grid, faces a direction, and follows a list of commands to move around, turn, and toggle suction on/off.

**How it works**

• You tell it the size of the room by giving the top-right corner coordinates.

• You give each hoover’s starting position and a command string.

• The program runs through each hoover’s commands one by one.

**Commands**

• L and R rotate the hoover left or right and automatically turn suction off.

• M moves the hoover forward one step if it’s inside the room.

• S toggles the suction on or off manually.

The program also keeps track of the hoover’s position, facing direction, and suction state.
After the processing the commands for each hoover, the final position, direction and suction (on/off) will be printed.

**What I focused on**

• Hoover limited by the size of the grid.

• Turning off suction automatically whenever it turns and moves South.

• Processing the hoovers one at a time, second hoover only starts when the first hoover is finished.

• Tried keeping the code clean and easy to understand with SOLID principles.

**What I’d do next if I had more time**

• Think about the possibility of obstacles in the grid.

• Handling any obstacles if encountered.

• Add unit tests throughout.

**How to run it**

• Compile and run the program.

• Manually add the inputs needed or paste the input exactly as specified (grid size, then pairs of lines for each hoover).

• If successful should return the printed results for each hoover. 

![Demo of Hoover running](./images/HooverAssignmentDemo.gif)
