/*
 Dati 2 numeri in ingresso, contare quanti multipli del numero 3 sono presenti tra i due numeri.
Esempio:
se vengono inseriti i numeri 4 e il numero 12..... i multipli saranno 3 (ovvero il numero 6, il numero 9, il numero 12).
 Risolevre con il For
Poi contare i multipli del numero 5 presenti tra i due numeri, usando il while
 */


namespace Esercizio_ContaMultipli
{
    internal class Program
    {
        static void Main()
        {

            int numI1;
            int numF2;
            int contaMultipli = 0;
            int contaMultipli5 = 0;
            int conta5;
            Console.WriteLine("inserire il numero da cui iniziare a contare");
            while(!(int.TryParse(Console.ReadLine(), out numI1)))
            {
                Console.WriteLine("inserire un numero valido");
            }
            Console.WriteLine("inserire il numero a cui finire di contare");
            while (!(int.TryParse(Console.ReadLine(), out numF2)))
            {
                Console.WriteLine("inserire un numero valido");
            }
            if (numI1 < numF2)
            {
                for (int conta = numI1; conta <= numF2; conta += 1)
                {
                    if (conta % 3 == 0)
                    {
                        contaMultipli++;
                    }
                }
                conta5 = numI1;
                while (conta5 <= numF2)
                {
                    if (conta5 % 5 == 0)
                    {
                        contaMultipli5++;
                    }
                    conta5++;
                }
            }
            else
            {
                for (int conta = numF2; conta <= numI1; conta += 1)
                {
                    if (conta % 3 == 0)
                    {
                        contaMultipli++;
                    }
                }
                conta5 = numF2;
                while (conta5 <= numI1)
                {
                    if (conta5 % 5 == 0)
                    {
                        contaMultipli5++;
                    }
                    conta5++;
                }
            }
            Console.WriteLine($"Il numero di multipli di 3 tra {numI1} e {numF2} è {contaMultipli}");
            Console.WriteLine($"Il numero di multipli di 5 tra {numI1} e {numF2} è {contaMultipli5}");
        }
    }
}
