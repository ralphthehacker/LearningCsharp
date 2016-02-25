using System;

namespace LearningCsharp
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Initialize the variables
			string firstName="";
			string lastName = "";
			string birthDate = ""; 
			string address1 = "";
			string address2 = "";
			string cityName = "";
			string stateName = "";
			string zipCode = "";
			string countryName = "";
			string promptMessage = "";
			string user_input = "";
			for(int i = 1; i < 10; i++ ){

				// Prompt the user for information and collect info
				switch(i) {

				case 1:
					promptMessage = "What is your first name?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					firstName = Convert.ToString(user_input);
					break;

				case 2:
					promptMessage = "What is your last name?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					lastName = Convert.ToString(user_input);
					break;

				case 3:
					promptMessage = "What is your birth date?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					birthDate = Convert.ToString(user_input);
					break;

				case 4:
					promptMessage = "What is your Address(line 1)?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					address1 = Convert.ToString(user_input);
					break;
				case 5:
					promptMessage = "What is your Address(line 2 )?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					address2 = Convert.ToString(user_input);
					break;

				case 6:
					promptMessage = "What is your City?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					cityName = Convert.ToString(user_input);
					break;
				
				case 7:
					promptMessage = "What is your State/Province?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					stateName = Convert.ToString(user_input);
					break;
				case 8:
					promptMessage = "What is your ZIP/Postal code?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					zipCode = Convert.ToString(user_input);
					break;

				case 9:
					promptMessage = "What is your Country?";
					Console.WriteLine (promptMessage);
					user_input = Console.ReadLine();
					countryName = Convert.ToString(user_input);
					break;

				}



			}

			// Now convert to the correct data types
			DateTime birth = Convert.ToDateTime(birthDate);
			long zip = Convert.ToInt64 (zipCode);


			// Now, print the information that the user provided
			Console.WriteLine("");
			Console.WriteLine (firstName);
			Console.WriteLine (lastName);
			Console.WriteLine (birth);
			Console.WriteLine (address1);
			Console.WriteLine (address2);
			Console.WriteLine (cityName);
			Console.WriteLine (stateName);
			Console.WriteLine (zip);
			Console.WriteLine(countryName);


		}
	}
}
