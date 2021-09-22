using System;


namespace ConsoleApp1
{
    public class App
    {
        static void Main(string[] args)
        {
            //Exercice1.StartMultiplication_impair(AskUserForParameter());
            //Exercice2.StartExercice2();
            //Exercice3.StartExercice3_TC();
            //Exercice4.StartEx4();
            Exercice5.StartExercice5();
            
        }
        public static int AskUserForParameter()
        {
            Console.WriteLine("Choisisez un chiffre entre 1 et 100");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}

