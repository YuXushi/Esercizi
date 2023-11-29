/*
Genero 50 numeri interi casuali con valori compresi tra 1 e 10
e li visualizzo sul console
*/

internal class Program
{
    private static void Main(string[] args)
    {   
        // preparo l'oggetto random
        Random casuale = new Random();
        int conta = 0;
        while (conta < 50)
        {
            Console.WriteLine(casuale.Next(1, 11));
            conta++;
        }

        Console.ReadLine();
        
        Random random = new Random();
        int num = 0;
        int numPari = 0;
        int numDisp = 0;
        while (num < 60)
        {
            int value = random.Next(1, 101);
            Console.WriteLine(value);
            num++;
            if (value % 2 == 0)
            {
                numPari++;
            }
            else
            {
                numDisp++;
            }
        }
        Console.WriteLine($"in totale c'erano {numPari} numeri pari");
        Console.WriteLine($"in totale c'erano {numDisp} numeri dispari");

        Console.ReadLine();
        Random value1 = new Random();
        int indov = value1.Next(1, 101);
        int indovnum = 0;
        Console.WriteLine("Inserisci un Numero");
        indovnum = int.Parse(Console.ReadLine());
        Console.WriteLine($"Il numero inserito è {indovnum}");
        while (!(indovnum == indov))
        if (indovnum < indov)
        {
            Console.WriteLine("Il valore è più grande");
            Console.WriteLine("Inserire un nuovo numero");
            indovnum = int.Parse(Console.ReadLine());
        }
        else
        {
                Console.WriteLine("Il valore è più piccolo");
                Console.WriteLine("Inserire un nuovo numero");
                indovnum = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Il valore è giusto!");
    }
}
