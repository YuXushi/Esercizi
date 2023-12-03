namespace Esercizio_Bool_Y_N_Casa
{
    internal class Program
    {
        static void Main()
        {
            bool Restart = false;
            string termine;
            string text;
            while (Restart == false)
            {
                Console.WriteLine("Inserisci Y o N");
                text = Console.ReadLine();
                text = text.ToLower();
                char first = text[0];
                if (first == 'y')
                {
                    Console.WriteLine("Hai inserito Y");
                    Console.WriteLine("Vuoi Terminare il Programma? [Y/N]");
                    termine = Console.ReadLine();
                    termine = termine.ToLower();
                    char firstT = termine[0];
                    if (firstT == 'n')
                    {
                        Restart = false;
                        Console.Clear();
                    }
                    else if (firstT == 'y')
                    {
                        Restart = true;
                    }
                }
                else
                {
                    Console.WriteLine("Hai inserito N");
                    Console.WriteLine("Vuoi Terminare il Programma? [Y/N]");
                    termine = Console.ReadLine();
                    termine = termine.ToLower();
                    char firstT = termine[0];
                    if (firstT == 'n')
                    {
                        Restart = false;
                        Console.Clear();
                    }
                    else if (firstT == 'y')
                    {
                        Restart = true;
                    }
                }
            }
            Console.WriteLine("Fine Programma");
        }
    }
}
