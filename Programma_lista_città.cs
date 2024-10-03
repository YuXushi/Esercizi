namespace Programma_lista_città
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listaCittà = new();
            bool y = true;
            while (y == true)
            {
                char scelta;
                bool x = true;
                Console.WriteLine("Inserisci una delle seguenti opzioni:");
                Console.WriteLine("1. Se si vuole caricare una città nella lista.");
                Console.WriteLine("2. Se si vuole inserire una città e contare quante volte è presente nella lista.");
                Console.WriteLine("3. Se si vuole generare una lista di tutte le città che iniziano con una lettera inserita da te.");
                Console.WriteLine("4. Se si vuole visualizzare la lista delle città.");
                while (x == true)
                {
                    while (!char.TryParse(Console.ReadLine(), out scelta))
                    {
                        Console.WriteLine("Inserisci un solo numero valido");
                    }
                    if (scelta == '1')
                    {
                        x = false;
                        caricaCittà(listaCittà);
                    }
                    else if (scelta == '2')
                    {
                        x = false;
                        contaCittà(listaCittà);
                    }
                    else if (scelta == '3')
                    {
                        x = false;
                        tutteCitt(listaCittà);
                    }
                    else if (scelta == '4')
                    {
                        x = false;
                        visualizzaCittà(listaCittà);
                    }
                    else
                    {
                        Console.WriteLine("Inserisci un numero valido");
                    }
                }
                bool t = true;
                while (t == true)
                {
                    Console.WriteLine("Si desidera fare un'altra azione?[Y/N]");
                    char restart2 = Console.ReadLine().ToLower()[0];
                    if (restart2 == 'n')
                    {
                        y = false;
                        t = false;
                    }
                    else if (restart2 == 'y')
                    {
                        t = false;
                    }
                    else
                    {
                        Console.WriteLine("Inserire Y o N");
                    }
                }
            }
        }
        static void caricaCittà(List<string> listaCitt)
        {
            bool restart = true;
            while (restart == true)
            {
                string w;
                bool restart4 = true;
                char restart1;
                bool restart5;
                bool restart3 = true;
                Console.WriteLine("Inserisci il nome di una città da caricare");
                while (restart4 == true)
                {
                    w = Console.ReadLine().ToLower();
                    if (w == string.Empty)
                    {
                    }
                    else
                    {
                        restart4 = false;
                    }

                }
                while (restart3 == true)
                {
                    Console.WriteLine("Vuoi inserire un'altra città? [Y/N]");
                    restart1 = Console.ReadLine().ToLower()[0];
                    if (restart1 == 'n')
                    {
                        restart = false;
                        restart3 = false;
                    }
                    else if (restart1 == 'y')
                    {
                        restart3 = false;
                    }
                    else
                    {
                        Console.WriteLine("Inserire Y o N.");
                    }
                }
            }
        }
        static void contaCittà(List<string> listaCitt)
        {
            Console.WriteLine("Inserisci una città da trovare:");
            string city = Console.ReadLine();
            int contaCity = listaCitt.FindAll(valore => valore.ToLower() == city.ToLower()).Count();
            Console.WriteLine($"La città richiesta è presente {contaCity} volte");
        }
        static void tutteCitt(List<string> listaCitt)
        {
            Console.WriteLine("Inserisci una lettera:");
            string lettera = Console.ReadLine();
            List<string> listaIniziali = listaCitt.FindAll(valore => valore.ToLower().StartsWith(lettera.ToLower()));
            Console.WriteLine($"le città che iniziano con {lettera} sono:");
            visualizzaCittà(listaIniziali);
        }
        static void visualizzaCittà(List<string> listaCitt)
        {
            Console.Write(string.Join("; ", listaCitt));
            Console.WriteLine();
        }
    }
}
