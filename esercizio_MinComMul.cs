/*
Scrivere un programma che calcoli il mcm (minimo comune multiplo) di due numeri a e b letti da tastiera
 */


namespace esercizio_MinComMul
{
    internal class Program
    {
        static void Main()
        {
            int num1;
            int num2;
            Console.WriteLine("Inserire il primo numero");
            while (!(int.TryParse(Console.ReadLine(), out num1) & num1 > 0))
            {
                Console.WriteLine("Inserire un numero valido e maggiore di zero");
            }
            Console.WriteLine("Inserire il secondo numero");
            while (!int.TryParse(Console.ReadLine(), out num2) & num2 > 0)
            {
                Console.WriteLine("Inserire un numero valido e maggiore di zero");
            }
            int conta;
            if (num1 < num2)
            {
                for (conta = 1; conta % num1 != 0 || conta % num2 != 0; conta++)
                {

                }
                Console.WriteLine($"il minimo comune multiplo di {num1} e {num2} è {conta}");
            }
            else if (num1 == num2)
            {
                conta = num1 = num2;
                Console.WriteLine($"il minimo comune multiplo di {num1} e {num2} è {conta}");
            }
            else
            {
                for (conta = 1; conta % num1 != 0 || conta % num2 != 0; conta++)
                {

                }
                Console.WriteLine($"il minimo comune multiplo di {num2} e {num1} è {conta}");
            }
        }
    }
}
