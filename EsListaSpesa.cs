namespace EsListaSpesa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finito = false;
            List<string> ListaSpesa = new List<string>();
            while (finito == false)
            {
                Console.WriteLine("Programma per tenere una lista della spesa.");
                Console.WriteLine();
                Console.WriteLine("Inserire una delle seguenti opzioni:");
                Console.WriteLine("1. Visualizzare la lista.");
                Console.WriteLine("2. Aggiungere un elemento alla lista.");
                Console.WriteLine("3. Rimuovere un elemento dalla lista.");
                Console.WriteLine("4. Cercare un elemento nella lista.");
                int scelta;
                while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta > 0 && scelta < 5))
                {
                    Console.WriteLine("Inserire una opzione valida.");
                }
                if (scelta == 1)
                {
                    VisualizzaLista(ListaSpesa);
                }
                else if (scelta == 2)
                {
                    AggiungiSpesa(ListaSpesa);
                }
                else if (scelta == 3)
                {
                    RimuoviSpesa(ListaSpesa);
                }
                else if (scelta == 4)
                {
                    CercaSpesa(ListaSpesa);
                }
                Console.WriteLine();
                bool finitoT = false;
                while (finitoT == false)
                {
                    Console.WriteLine("Desidera utilizzare un'altra opzione? [Y/N]");
                    char finitoP = Console.ReadLine().ToLower()[0];
                    if (finitoP == 'y')
                    {
                        finitoT = true;
                    }
                    else if (finitoP == 'n')
                    {
                        finitoT = true;
                        finito = true;
                    }
                    else
                    {
                        Console.WriteLine("Inserire una opzione valida");
                    }
                }
            }
        }
        static void VisualizzaLista(List<string> ListaSpesa)
        {
            if (ListaSpesa.Count == 0)
            {
                Console.WriteLine("La lista non contiene nessun elemento.");
            }
            else
            {
                Console.Write(string.Join("; ", ListaSpesa));
                Console.WriteLine();
            }
        }
        static void AggiungiSpesa(List<string> ListaSpesa)
        {
            bool finito = false;
            while (finito == false)
            {
                Console.WriteLine("Inserire l'elemento da aggiungere");
                string aggiungi = Console.ReadLine().ToLower();
                ListaSpesa.Add(aggiungi);
                bool finitoT = false;
                while (finitoT == false)
                {
                    Console.WriteLine("Desidera aggiungere un'altro elemento alla lista? [Y/N]");
                    char scelta = Console.ReadLine().ToLower()[0];
                    if (scelta == 'y')
                    {
                        finitoT = true;
                    }
                    else if (scelta == 'n')
                    {
                        finitoT = true;
                        finito = true;
                    }
                    else
                    {
                        Console.WriteLine("Inserire una opzione valida");
                    }
                }
            }
        }
        static void RimuoviSpesa(List<string> ListaSpesa)
        {
            bool finito = false;
            while (finito == false)
            {
                Console.WriteLine("Inserire l'elemento da rimuovere");
                string rimuovi = Console.ReadLine().ToLower();
                ListaSpesa.Remove(rimuovi);
                bool finitoT = false;
                while (finitoT == false)
                {
                    Console.WriteLine("Desidera rimuovere un'altro elemento dalla lista? [Y/N]");
                    char scelta = Console.ReadLine().ToLower()[0];
                    if (scelta == 'y')
                    {
                        finitoT = true;
                    }
                    else if (scelta == 'n')
                    {
                        finitoT = true;
                        finito = true;
                    }
                    else
                    {
                        Console.WriteLine("Inserire una opzione valida");
                    }
                }
            }
        }
        static void CercaSpesa(List<string> ListaSpesa)
        {
            bool finito = false;
            while (finito == false)
            {
                Console.WriteLine("Inserire l'elemento da cercare");
                string cerca = Console.ReadLine().ToLower();
                int trova = ListaSpesa.IndexOf(cerca);
                if (trova > 0)
                {
                    Console.WriteLine("L'elemento è presente nella lista");
                }
                else
                {
                    Console.WriteLine("L'elemento non è stato trovato");
                }
                bool finitoT = false;
                while (finitoT == false)
                {
                    Console.WriteLine("Desidera trovare un'altro elemento nella lista? [Y/N]");
                    char scelta = Console.ReadLine().ToLower()[0];
                    if (scelta == 'y')
                    {
                        finitoT = true;
                    }
                    else if (scelta == 'n')
                    {
                        finitoT = true;
                        finito = true;
                    }
                    else
                    {
                        Console.WriteLine("Inserire una opzione valida");
                    }
                }
            }
        }
    }
}
