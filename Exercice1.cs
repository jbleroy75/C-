using System;

namespace ConsoleApp1
{
	public class Exercice1
	{
		public static void StartMultiplication_impair(int number)
		{
			int n = 5;
			Console.WriteLine("Table of : " + number);
			for (int i = 1; i <= 10; i++)
				if (number * i % 2 != 0) 
					Console.WriteLine(number + "*" + i+ "=" + number * i);
		}
	}
}
		