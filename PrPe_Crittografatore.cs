namespace PrPe_Crittografatore
{
    internal class Program
    {
        static void Main()
        {
            int chiave;
            Console.WriteLine("Inserisci la chiave della crittografia");
            while (!int.TryParse(Console.ReadLine(), out chiave))
            {
                Console.WriteLine("Inserire una chiave valida");
            }
            Console.WriteLine("vuoi crittografare o decrittografare? Inserisci C per crittografare, inserisci D per decrittografare [C/D]");
            string placeholder = Console.ReadLine().ToLower();
            char[] character = placeholder.ToCharArray();

        }
    }
}
