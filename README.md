# TicTacToe Console Game

 This is a simple console-based Tic Tac Toe game implemented in C# with the ability to restart the game after completion (there is a version without an available restart in the repository). The game allows two players to take turns marking spaces on a 3x3 grid until one player wins or the game ends in a tie.
## Game overview
  
### 1.Welcome Message:
• Players are greeted with a welcome message explaining the game rules.  
• Player 1 marks spaces with 'X', and Player 2 marks spaces with 'O'.  
• Players take turns choosing a field by entering a number from 1 to 9.
### 2.Game Board:
• The game board is displayed after each move, showing the current state of the game.
### 3.Winning Conditions:
• The game checks for winning conditions after each move.  
• Winning conditions include completing a row, column, or diagonal with the same marker.
### 4.Tie Game:
• If all spaces are filled, and no player has won, the game ends in a tie.
### 5.Restart or Quit:
• After a game concludes (either due to a win or a tie), players are given the option to restart or quit.  
• Press any key to restart the game or 'Q' to quit.  
## Game Logic
The game logic is implemented using a simple console application with a main loop that allows for multiple rounds and restarts.
The board is represented by an array of characters, and players input their moves through the console.
Winning conditions are checked after each move to determine if a player has won.
The game is designed to be user-friendly, providing clear messages and prompts throughout.  
## Source Code Links
• [Game version without restart](https://github.com/DenitsaBebrevenska/TicTacToeConsole/blob/master/TicTacToe/Program.cs)  
• [Game version with available restart upon completition](https://github.com/DenitsaBebrevenska/TicTacToeConsole/blob/master/TicTacToeWithRestartAvailable/Program.cs) 
## Screenshots
• Welcoming screen  
![welcoming screen](https://github.com/DenitsaBebrevenska/TicTacToeConsole/assets/141340307/d5fe05c6-5fc8-4256-b778-a2a85ccaa116)  
• Board  
![board](https://github.com/DenitsaBebrevenska/TicTacToeConsole/assets/141340307/434f6651-1390-4302-b095-611927bb326f)  
• Win  
![win](https://github.com/DenitsaBebrevenska/TicTacToeConsole/assets/141340307/80468b8e-f613-409c-be23-5967bcd983f1)  
• Tie   
![tie](https://github.com/DenitsaBebrevenska/TicTacToeConsole/assets/141340307/3d00b7ba-05fe-495c-b376-b35d814bb550)  
• Invalid input   
![invalid input](https://github.com/DenitsaBebrevenska/TicTacToeConsole/assets/141340307/00683a04-2898-435d-9d54-c1b283e3b9a1)  
• Field already taken/ marked by the other player   
![field taken](https://github.com/DenitsaBebrevenska/TicTacToeConsole/assets/141340307/0e2c9816-b016-445b-8ed4-18bec902d27a)   

## Live Demo Replit
[Clicky!](https://replit.com/@denitsabebreven/TicTacToe-Console-Game)
