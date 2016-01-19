using System;

namespace Conditionals
{
	class MainClass
	{
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
			for (int i = 0; i < 10; ++i) {
				if (i == 5) {
					continue;
				}
				Console.Write ("Happy Birthday! {0} ", i);
			}
			Console.WriteLine ("\nTaDa!!");

		}
	}
}
	