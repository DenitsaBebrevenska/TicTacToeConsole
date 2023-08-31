namespace TicTacToeWithRestartAvailable
{
	internal class Program
	{
		public static char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		public static string userInput = "";
		public static bool winAchieved = false, restart = true;

		static void Main(string[] args)
		{

			while (restart)
			{
				ResetBoard(); 
				int turn = 1, counter = 0;
				Welcome(); //welcome message
				while (!winAchieved || counter < 9) //counter reaching 9 = all 9 spots are taken but no one won = tie
				{
					int result = 0;
					bool exceptionInput = false;
					Console.WriteLine($"Player {turn} choose a field: ");
					userInput = Console.ReadLine();
					try
					{
						result = int.Parse(userInput);
					}
					catch (Exception)
					{
						exceptionInput = true;
					}

					if (exceptionInput || (result < 1 || result > 9)) // if input an invalid: char/string or number out of range?
					{
						Console.WriteLine($"Invalid input! Player {turn} please choose a number from 1 to 9!");
						continue;
					}

					if (numbers[result] != 'X' && numbers[result] != 'O') //if valid input
					{
						if (turn == 1)
						{
							numbers[result] = 'X';
						}
						else
						{
							numbers[result] = 'O';
						}
						counter++;
					}
					else //if valid but field already taken
					{
						Console.WriteLine($"That field is already marked! Make another choice Player {turn}!");
						continue;
					}

					winAchieved = CheckForWin();
					if (winAchieved)
					{
						UpdateBoard();
						Console.WriteLine($"Congratulations, Player {turn}! You win!");
						break;

					}
					else if (counter == 9)
					{
						UpdateBoard();
						Console.WriteLine("It`s a tie!");
						break;
					}

					turn++;
					if (turn > 2) // switching between players
					{
						turn = 1;
					}
					UpdateBoard();
				}
				RestartOrEnd();
            }

		}
		public static bool CheckForWin()
		{
			if ((numbers[1] == numbers[2] && numbers[1] == numbers[3]) || (numbers[4] == numbers[5] && numbers[4] == numbers[6])
				|| (numbers[7] == numbers[8] && numbers[7] == numbers[9])) // checks rows
			{ return true; }
			else if ((numbers[1] == numbers[4] && numbers[1] == numbers[7]) || (numbers[2] == numbers[5] && numbers[2] == numbers[8])
				|| (numbers[3] == numbers[6] && numbers[3] == numbers[9])) //checks columns
			{ return true; }
			else if ((numbers[1] == numbers[5] && numbers[1] == numbers[9])
				|| (numbers[3] == numbers[5] && numbers[3] == numbers[7])) //checks diagonals
			{ return true; }
			else
			{ return false; }
		}
		public static void SetBoard()
		{
			Console.WriteLine("      |      |      ");
			Console.WriteLine($"  {numbers[1]}   |  {numbers[2]}   |  {numbers[3]}  ");
			Console.WriteLine("______|______|______");
			Console.WriteLine("      |      |      ");
			Console.WriteLine($"  {numbers[4]}   |  {numbers[5]}   |  {numbers[6]}  ");
			Console.WriteLine("______|______|______");
			Console.WriteLine("      |      |      ");
			Console.WriteLine($"  {numbers[7]}   |  {numbers[8]}   |  {numbers[9]}  ");
			Console.WriteLine("      |      |      ");
		}
		public static void ResetBoard() //to initial state with numbers
		{
			for (int i = 0; i < 10; i++)
			{
				char valueChar = (char)(i + '0');
				numbers[i] = valueChar;
			}
		}
		public static void Welcome()
		{
			Console.WriteLine("Welcome! Let`s play some Tic Tac Toe!");
			Console.WriteLine("Player 1 is using X to mark!");
			Console.WriteLine("Player 2 is using O to mark!");
			Console.WriteLine("Good luck!");
			Console.WriteLine("Press any key to start the game: ");
			Console.ReadKey();
			UpdateBoard();

		}
		public static void UpdateBoard()
		{
			Console.Clear();
			SetBoard();
		}
		public static void RestartOrEnd()
		{
			Console.WriteLine("Do you want to restart the game?");
			Console.WriteLine("Press any key to restart or \"Q\" to quit:");

			var key = Console.ReadKey();
			if (key.KeyChar == 'q' || key.KeyChar == 'Q')
			{
				restart = false;
			}
			else
			{
				Console.Clear();

			}
		}
	}
}