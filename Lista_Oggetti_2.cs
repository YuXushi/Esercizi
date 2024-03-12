namespace Lista_Oggetti_2
{
    class Studente
    {
        public string Nome { get; set; }
        public string Cognome;

        private string classe; //Contenitore di Classe
        public string Classe //Gestore dei contenuti di classe
        {
            get { return classe; } 
            set
            {
                if(value.StartsWith("1") || value.StartsWith("2") || value.StartsWith("3") || value.StartsWith("4") || value.StartsWith("5")) // Filtro per classe
                {
                    classe = value;
                }
                else
                {
                    throw new Exception("Stringa classe non corretta.");
                }
            }
        }
        private int votoInformatica;
        public int VotoInformatica
        {
            get { return votoInformatica; } // Get fa vedere il valore, e riturna il valore(?) da votoInformatica dopo il set(?)
            set // Setta il valore di votoInformatica
            {
                if (value >= 2 && value <= 10) // L'if fa da filtro al valore dato inoltre, così che votoInformatica non sia errato
                {
                    votoInformatica = value;
                }
                else
                {
                    throw new Exception("Il voto non è valido"); // Setta Exception come "Il voto non è valido"
                }
            }
        }
        // Il costruttore
        public Studente() // Il costruttore setta il default delle funzioni,
        { //Visualizzandolo senza niente ritorna questi valori
            Nome = "?";
            Cognome = "?";
            Classe = "1?";
            votoInformatica = 2;
        }
        



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Studente st = new Studente(); // esempio di oggetto di tipo Studente
                Console.WriteLine(st.Classe); // Se si visualizza il valore, solo il get viene attivato
                st.Classe = "3BINF"; // Se siamo noi che mettiamo un valore al oggetto, si attiva il set invece
                Console.WriteLine(st.Classe);
                // ^Esempio

                // Lista di oggetti
                List<Studente> listaStudenti = new List<Studente>(); // List<Studente> listaStudenti = new();

                int scelta;
                // Facciamo un menù

                Console.WriteLine("Inserisci 1 per caricare allievo, 2 per ricarca . . . E premi altro per chiudere");
                while (int.TryParse(Console.ReadLine(), out scelta) && scelta > 0 && scelta < 5)
                {
                    if (scelta == 1)
                    {
                        CaricaLista(listaStudenti);
                    }
                    else if (scelta == 2)
                    {

                    }

                    Console.WriteLine("Inserisci 1 per caricare allievo, 2 per ricarca . . . E premi altro per chiudere");
                    //
                }
            }
            catch (Exception ex) // se 3BINF fosse BINF, e il set non lo valida, il try lascia tutto al catch,
            {
                // che prende il throw da Classe(throw new Exception("Stringa classe non corretta.");), quindi ex diventa quello che a preso
                Console.WriteLine(ex.Message);
            }
        }

        static void CaricaLista(List<Studente> listaStudenti)
        {
            try
            {
                Studente st = new Studente();
                Console.WriteLine("Inserisci il nome dell'allievo da inserire");
                // Dovrebbe esserci un controllo qui con il while
                st.Nome = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome dell'allievo da inserire");
                st.Cognome = Console.ReadLine();
                Console.WriteLine("Inserisci la classe dell'allievo da inserire");
                st.Classe = Console.ReadLine();
                Console.WriteLine("Inserisci il voto di informatica dell'allievo da inserire");
                st.VotoInformatica = int.Parse(Console.ReadLine());
                // la aggiungo alla lista
                listaStudenti.Add(st);
                visualizzaLista(listaStudenti);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void visualizzaLista(List<Studente> listaStudenti)
        {
            try
            {
                foreach (var st in listaStudenti) // var fa sì che st diventi stringa o del tipo di listaStudenti è
                {
                    Console.WriteLine($"Nome = {st.Nome}; Cognome = {st.Cognome}; Classe = {st.Classe}; Voto = {st.VotoInformatica};");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
