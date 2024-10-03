namespace Esercizio_CaseNLoop
{
    internal class Program
    {
        static void Main()
        {
            bool restart = true;
            while (restart = true)
            {
                int choice;
                Console.WriteLine("Inserisci il numero 1 se vuoi 10 numeri generati con For, inserisci 2 se vuoi 10 numeri generati con il while");
                while(!(int.TryParse(Console.ReadLine(), out choice)) && choice > 0)
                {
                    Console.WriteLine("Inserisci un valore valido");
                }
                switch (choice)
                {
                    case 1:
                        for(int x = 0; x < 10; x++)
                        {
                            Console.WriteLine($"{x}");
                        }
                        break;
                    case 2:
                        int y = 0;
                        while (y < 10)
                        {
                            y++;
                            Console.WriteLine($"{y}");
                        }
                        break;
                    default:
                        Console.WriteLine("Inserisci un valore valido");
                        break;
                }
                Console.WriteLine("Vuole riavviare il programma?");
                char restartChoice = Console.ReadLine().ToLower()[0];
                if (restartChoice == 's')
                {
                    restart = false;
                }
                else
                {
                    Console.WriteLine("Il programma è stato riavviato");
                }
            }
        }
    }
}
