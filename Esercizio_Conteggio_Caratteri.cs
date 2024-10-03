internal class Program
{
    private static void Main(string[] args)
    {
        string parola;
        Console.WriteLine("inserisci una parola");
        parola = Console.ReadLine();
        int lunghezza = parola.Length;
        Console.WriteLine("caratteri in ordine");


        for (int i = 0; i < lunghezza; i++)
        {
            Console.WriteLine(parola[i]);
            Thread.Sleep(100);
        }
        Console.WriteLine("caratteri in ordine sparso");
        Random sium = new Random();
        while (parola.Length > 0)
        {
            int index = sium.Next(0, parola.Length);
            char carattere = parola[index];
            Console.WriteLine(carattere);
            parola = parola.Remove(index, 1);
            Thread.Sleep(100);
        }
    }
}
