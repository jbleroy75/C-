using System;

namespace ConsoleApp1
{
    public class Exercice4
    {
        public static void StartEx4()
        {
            int n = AskUserForParameter();
            int m = AskUserForParameter();
            Console.Write("o");
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write("_");
            }

            Console.WriteLine("o");



            for (int z = 0; z < m-2; z++){
                Console.Write("|");
                for (int j = 1; j < n-1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }

            Console.Write("o");
            for (int i = 1; i < n-1; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("o");
            
        }

        public static int AskUserForParameter()
        {
            Console.WriteLine("Choisisez un chiffre entre 1 et 100");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
    
}

