/*
trovare tutti i divisori di un numero intero
inserito dall'utente
versione semplice non ottimizzata
 */

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Inserire un numero intero");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("I divisori sono:");
            int conta = 1;
            while (conta <= num)
            {
                if (num % conta == 0)
                {
                    Console.WriteLine(conta);
                }
                conta++;
            }

        }
        catch
        {

        }
    }
}
