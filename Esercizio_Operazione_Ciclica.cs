/*
INIZIO
leggi numero
mentre numero diviso 2 != 0 ripeti
leggi numero
ripeti
scrivi numero
fine
 */


internal class Program
{
    private static void Main(string[] args)
    {
            Console.WriteLine("inserisci un numero intero e pari");
            int num;  
            while(!int.TryParse(Console.ReadLine(), out num) || num % 2 != 0)
            {
                Console.WriteLine("Inserisci un numero intero e  pari");
            }
            Console.WriteLine($"il numero inserito: {num}");
    }
}
