namespace Esercizio_Magazino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magazzino.");
            bool end = false;
            while (end == false)
            {
                Random Casuale = new Random();
                List<classeProdotti> Magazzino = new List<classeProdotti>();
                classeProdotti Mag = new classeProdotti("Apple Keyboard", "Tastiera", "Apple", 99.99, Casuale.Next(1, 501));
                Magazzino.Add(Mag);
                Mag = new classeProdotti("Samsung Galaxy Watch4", "SmartWatch", "Samsung", 109.00, Casuale.Next(1, 201));
                Magazzino.Add(Mag);
                Mag = new classeProdotti("Apple iPad (9a generazione)", "iPad", "Apple", 349.00, Casuale.Next(1, 301));
                Magazzino.Add(Mag);
                Mag = new classeProdotti("TV Ultra HD 4K Smart TV Samsung", "TV", "Samsung", 413.60, Casuale.Next(1, 401));
                Magazzino.Add(Mag);
                int scelta;
                Console.WriteLine("Scelgliere una delle seguenti opzioni:");
                Console.WriteLine("1. Visualizzare i prodotti presenti nel magazzino");
                Console.WriteLine("2. Controllare un prodotto richiesto dall'utente per tipologia e prezzo massimo");
                while (!(int.TryParse(Console.ReadLine(), out scelta) || scelta >= 1 || scelta <= 2))
                {
                    Console.WriteLine("Inserire una scelta valida");
                }
                if (scelta == 1)
                {
                    visualizza(Magazzino);
                }
                else if (scelta == 2)
                {
                    trovaProdotto(Magazzino);
                }
            }
        }
        static void visualizza(List<classeProdotti> Magazzino)
        {
            List<classeProdotti> org = new List<classeProdotti>();
            Console.WriteLine("Prodotti nel magazzino in base al fornitore");
            org = Magazzino.OrderBy(x => x.Fornitore).ToList();
            foreach (classeProdotti y in org)
            {
                Console.WriteLine("------------------------" + '\n'
                    + "Nome Prodotto: " + y.nomeProdotto + '\n'
                    + "Fornitore: " + y.Fornitore + '\n'
                    + "Tipologia: " + y.Tipologia + '\n'
                    + "Prezzo per pezzo: " + y.prezzoUnitario + '\n'
                    + "Quantita nel magazzino: " + y.quantitaMagazzino + '\n'
                    + "------------------------");
            }
            Console.WriteLine();
            Console.WriteLine("Prodotto nel magazzino in base al prezzo unitario");
            org = Magazzino.OrderBy(x => x.prezzoUnitario).ToList();
            foreach (classeProdotti y in org)
            {
                Console.WriteLine("------------------------" + '\n' 
                    + "Nome Prodotto: " + y.nomeProdotto + '\n' 
                    + "Fornitore: " + y.Fornitore + '\n' 
                    + "Tipologia: " + y.Tipologia + '\n' 
                    + "Prezzo per pezzo: " + y.prezzoUnitario + '\n' 
                    + "Quantita nel magazzino: " + y.quantitaMagazzino + '\n'
                    + "------------------------");
            }
        }
        static void trovaProdotto(List<classeProdotti> Magazzino)
        {
            Console.WriteLine("Inserire il tipo di prodotto");
            Console.WriteLine("Inserire il prezzo massimo desiderato");






        }
    }
}
