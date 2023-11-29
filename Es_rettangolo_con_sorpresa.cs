using System.Linq.Expressions;

internal class Program
{
    private static void Main()
    {
        int restoro;
        int colonna;
        int righa;
        char lettera;
        Console.WriteLine("Inserire un carattere");
        while (!char.TryParse(Console.ReadLine(), out lettera))
        {
            Console.WriteLine("Inserisci un valore valido");
        }
        Console.WriteLine("Inserire un numero di colonne maggiore di zero");
        while (!(int.TryParse(Console.ReadLine(), out colonna) && colonna > 0))
        {
            Console.WriteLine("Inserisci un numero valido");
        }
        Console.WriteLine("Inserire un numero di colonne maggiore di zero");
        while (!(int.TryParse(Console.ReadLine(), out righa) && righa > 0))
        {
            Console.WriteLine("Inserisci un numero valido");
        }
        while(righa != 0)
        {
            restoro = colonna;
            while (restoro != 0)
            {
                Console.Write(lettera);
                restoro--;
            }
            Console.WriteLine();
            righa--;
        }
    }
}
