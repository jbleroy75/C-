using System;

namespace ConsoleApp1
{
    public class Exercice2
    {
        public static void StartExercice2()
        {
            Console.WriteLine("Exercice 2 Chiffres Premiers :");
            Exercice2_NB_Premier();
            Exercice2_FIBO();
            Exercice2_Factorielle();
        }

        public static void Exercice2_NB_Premier()
        {
            int n = AskUserForParameter();
            for (int i = 1; i < n; i++)
            {
                if (test_premier(i)== true)
                {
                    Console.WriteLine(i);
                }
            }
            
            
            
        }

        public static bool test_premier(int x)
        {
            if (x <= 2)
            {
                return true; 
            }
            for (int i = 2; i < x; i++)
            {
                if (x%i == 0)
                {
                    return false;
                    
                }
            }
            return true;
        }

        public static void Exercice2_FIBO()
        {
            Console.WriteLine("Exercice 2 FIBO:");
            int a=1;
            int b=0;
            int temp = 0;
            int n = AskUserForParameter();

            while (b < n)
            {
                Console.WriteLine(temp);
                temp = b + a;
                a = b;
                b = temp;
            }
            
        }
        public static void Exercice2_Factorielle()
        {
            Console.WriteLine("Exercice 2 Factorielle :");
            int n = AskUserForParameter();
            int tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            
            Console.WriteLine(tmp);
        }
        public static int AskUserForParameter()
        {
            Console.WriteLine("Choisisez un chiffre entre 1 et 100");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
    }
}