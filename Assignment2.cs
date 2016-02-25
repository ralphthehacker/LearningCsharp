using System;

namespace Assignment2
{
	public class Assignment2
	{


		public static void Main (String[] x)
		{
			// Prompt the user for the board size
			Console.WriteLine ("Welcome to chessboard! What board size would you like? (Size 2 or bigger)");
			int boardSize = Convert.ToInt32(Console.ReadLine());

			// Create a chessboard builder
			ChessboardBuilder cb = new ChessboardBuilder(boardSize);

			// And print the board
			cb.printChessboard();

		}

	}

	// This class builds the chessboard
	public class ChessboardBuilder
	{

		public string pattern1;
		public string pattern2;
		public int boardSize;

		public ChessboardBuilder(int size) {
			// Build the rows
			createPatterns(size);
			this.boardSize = size;
		}



		//This method prints the chessboard to the user
		public void printChessboard() {
			// Create a boolean flag to determine which row is being printed
			bool isRowEven = true;

			//Now, print the chessboard to the user
			for(int i = 0;i < this.boardSize; i++) {
				// See if the row is even
				isRowEven = (i % 2) == 0;

				//Redundancy for the sake of readability
				if (isRowEven == true) {
					Console.WriteLine (this.pattern1);
				} else {
					Console.WriteLine (this.pattern2);
				}

			}

		}

		// This method is used to create the chessboard's rows
		public void createPatterns(int size) {
			// Creating base templates and patterns
			string template1 = "XO";
			string template2 = "OX";
			string pattern1 = "";
			string pattern2 = "";

			//	If the board's size is less than 2, just return
			if (size < 2) {
				Console.WriteLine ("Invalid Size!");
				throw new ArgumentException("Size should be at least 2");
			
			} else {
				for (int i = 0; i < size/2; i++) {
					pattern1 = pattern1 + template1;
					pattern2 = pattern2 + template2;
				}
			}

			this.pattern1 = pattern1;
			this.pattern2 = pattern2;
		}



	}



	// Has a method, factorial, that recursively calculates the factorial of a number 
	public class FactorialPrinter
	{
		public long factorial(int num, int sum = 1){
			string a = "a";
			if (num <= 1) {
				return sum;
			} else {
				Console.WriteLine (a);
				sum *= num;
				num--;
				Console.WriteLine("Now calling factorial({0},{1})", sum,num);
				return factorial (num, sum);

			}

	}


	}
}

