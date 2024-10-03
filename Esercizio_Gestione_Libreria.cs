namespace Esercizio_Gestione_Libreria
{
    internal class Program
    {
        static void Main()
        {
            List<String> Libreria = new List<String>();
            bool finitoX = false;
            while (finitoX == false)
            {
                int scelta;
                Console.WriteLine("Selezionare una delle seguenti opzioni:");
                Console.WriteLine("1. Aggiungere un libro alla libreria");
                Console.WriteLine("2. Rimuovere un libro dalla libreria");
                Console.WriteLine("3. Cercare un libro nella libreria");
                Console.WriteLine("4. Visualizzare la libreria");
                while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta > 0 && scelta < 5))
                {
                    Console.WriteLine("Inserisci una opzione valido");
                }
                if (scelta == 1)
                {
                    aggiungiLibro(Libreria);
                }
                else if (scelta == 2)
                {
                    rimuoviLibro(Libreria);
                }
                else if (scelta == 3)
                {
                    cercaLibro(Libreria);
                }
                else if (scelta == 4)
                {
                    visualizzaLibro(Libreria);
                }
                char c;
                Console.WriteLine("Desidera prendere un'altra azione? [Y/N]");
                c = Console.ReadLine().ToLower()[0];
                while (!(c == 'y'|| c == 'n'))
                {
                    Console.WriteLine("Inserire una opzione valida [Y/N]");
                    c = Console.ReadLine().ToLower()[0];
                }
                if (c == 'n')
                    finitoX = true;
            }
        }
        static void aggiungiLibro(List<String> Libreria)
        {
            bool finitoX = false;
            while (finitoX == false)
            {
                Console.WriteLine("Inserire il nome del libro da aggiungere.");
                Libreria.Add(Console.ReadLine().ToLower());
                char c;
                Console.WriteLine("Desidera aggiungere un'altro libro? [Y/N]");
                c = Console.ReadLine().ToLower()[0];
                while (!(c == 'y' || c == 'n'))
                {
                    Console.WriteLine("Inserire una opzione valida [Y/N]");
                    c = Console.ReadLine().ToLower()[0];
                }
                if (c == 'n')
                    finitoX = true;
            }
        }
        static void rimuoviLibro(List<String> Libreria)
        {
            bool finitoX = false;
            while (finitoX == false)
            {
                Console.WriteLine("Inserire il nome del libro da rimuovere");
                Libreria.Remove(Console.ReadLine().ToLower());
                char c;
                Console.WriteLine("Desidera rimuovere un'altro libro? [Y/N]");
                c = Console.ReadLine().ToLower()[0];
                while (!(c == 'y' || c == 'n'))
                {
                    Console.WriteLine("Inserire una opzione valida [Y/N]");
                    c = Console.ReadLine().ToLower()[0];
                }
                if (c == 'n')
                    finitoX = true;
            }
        }
        static void cercaLibro(List<String> Libreria)
        {
            bool finitoX = false;
            while (finitoX == false)
            {
                Console.WriteLine("Inserire il nome del libro da rilevare");
                bool contiene = Libreria.Contains(Console.ReadLine().ToLower());
                if (contiene == true)
                {
                    Console.WriteLine("Il libro è presente nella libreria");
                }
                else
                {
                    Console.WriteLine("Il libro non è presente nella libreria");
                }
                char c;
                Console.WriteLine("Desidera cercare un'altro libro? [Y/N]");
                c = Console.ReadLine().ToLower()[0];
                while (!(c == 'y' || c == 'n'))
                {
                    Console.WriteLine("Inserire una opzione valida [Y/N]");
                    c = Console.ReadLine().ToLower()[0];
                }
                if (c == 'n')
                    finitoX = true;
            }
        }
        static void visualizzaLibro(List<String> Libreria)
        {
            Console.Write(string.Join("; ", Libreria));
            Console.WriteLine();
        }
    }
}
