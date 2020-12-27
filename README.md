## Lab C# Chapter 10: Tic Tac Toe
### This assignment was done in my Developing Cloud Applications Class.
This assignment is to create a Console Application that allows two people to play Tic-Tac-Toe. A basic outline / approach to writing this program is:

Use arrays, loops, ifs, user input, etc. to create a tic-tac-toe game.

Create a 3 x 3 tic-tac-toe board.

This will be a 3 x 3 array of char.
Initialize your tic-tac-toe board with dash characters ('-').

Inside of a loop . . .

Ask player 1 where he/she would like to move.

Input the numeric row.

Input the numeric col.

Put an 'X' at that location in the board array.

Print out the board.

Ask player 2 where he/she would like to move.

Input the numeric row.

Input the numeric col.

Put an 'O' at that location in the board array.

Print out the board.

Repeat.

The above description is the basic game logic.

Improvement: If you haven't done so yet, create a Method that will take the board array as a parameter and print out the board. Above, in the two places where you need to print out the board, make a call to this new Method.

Improvement: If you haven't done so yet, add some checking to make sure that the user input (the row and the col) is a valid move. Entering numbers that are outside the size of the board is invalid.

Improvement: If you haven't done so yet, add some error checking so that you don't allow one player to overwrite where the other player has already moved.

Bonus (+5 points): Try and figure out if someone has won.
