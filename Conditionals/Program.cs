using System;

namespace Conditionals
{
	class MainClass
	{
		// Added just for enumerated constant
		enum Color{
			Red,
			Orange,
			Green,
			Blue,
			Indigo,
			Violet
		}

		public static void Main (string[] args)
		{
			// IF ELSE
			// Console.Write ("What is your age?");
			// string ageAsString = Console.ReadLine();
			// int age = int.Parse (ageAsString);
			// 
			// if (age > 65) {
			// 	Console.WriteLine ("You are a senior citizen");
			// }else if (age >= 21){
			// 	Console.WriteLine ("You are an adult");
			// }else{
			// 	Console.WriteLine ("You are not yet a legal adult");
			// }

			// WHILE LOOP
			/*
			Console.Write("How old are you? ");
			int age = int.Parse (Console.ReadLine ());

			do{
				Console.Write ("Happy Birthday ");
				age--;
			} while (age > 0);

			Console.WriteLine ("\nTaDa!!");
			*/

			// FOR LOOP
				// All these are optional, could be:
				// int i = 0
				// for (;; ){
				// ++i;
				// if (i > 10){
				// 		break
				// }
			/*
			for (int i = 0; i < 10; ++i) {
				if (i == 5) {
					continue;
				}
				Console.Write ("Happy Birthday! {0} ", i);
			}
			Console.WriteLine ("\nTaDa!!");

			for (int i = 0; i < 2000; i++) {
				if (i % 100 == 0) {
					Console.WriteLine ("Happy Birthday! {0} ", i);
				}
			}
			*/

			// SWITCH
			/*
			Console.Write("Pick a number between 1 and 5: ");
			int choice = int.Parse (Console.ReadLine ());

			switch (choice) {
			case 6:
				// Case 6 will fall through and do what 5 is
			case 5:
				Console.WriteLine ("You picked the biggest legal num");
				break;
			case 4:
				Console.WriteLine ("Wow, you piecked a 4");
			default:
				Console.WriteLine ("Not a legal entry, please try again");
				break;
			}
			*/

			// ENUMERATED CONSTANTS
			Color favorite = Color.Red;

			switch (favorite) {
			case Color.Red:
				Console.WriteLine ("You chose Red");
				break;
			case Color.Orange:
				Console.WriteLine ("You chose orange");
				break;
			default:
				Console.WriteLine ("I dont know what you chose");
				break;
			}
		}
	}
}
	