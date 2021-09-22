using System;

namespace ConsoleApp1
{
    public class Exercice3
    {
        public static void StartExercice3_TC()
        {
            Console.WriteLine("Exercice 3 : Try&Catch");
            try
            {
                for (var i = -3; i <= 3; i++)
                    Console.WriteLine(10/PowerFunction(i));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) -4);
        }
    }
}