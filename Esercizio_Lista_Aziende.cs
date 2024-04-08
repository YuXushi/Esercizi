using System.Linq;


namespace Esercizio_Lista_Aziende 
{
    internal class Program
    {
        class Aziende
        {
            public string RagioneSociale { get; set; }

            public string Residenza { get; set; }

            public double Bilancio { get; set; }

            public string Tipologia { get; set; }

            //Costruttore
            public Aziende()
            {
                RagioneSociale = string.Empty;
                Residenza = string.Empty;
                Bilancio = 0;
                Tipologia = string.Empty;
            }
            //Posso definire altro costruttore purchè abbia un numero
            //Diverso di parametri
            public Aziende(string ragionesorciale, string residenza, double bilancio, string tipologia)
            {
                RagioneSociale = ragionesorciale;
                Residenza = residenza;
                Bilancio = bilancio;
                Tipologia = tipologia;
            }
        }
        static void Main(string[] args)
        {
            List<Aziende> listaAziende = new();
            Aziende azienda = new Aziende("Aleci SPA", "Biella", 20000, "IT");
            listaAziende.Add(azienda);
            azienda = new Aziende("Martinico SPA", "Corinto", 20000, "Metallurgia");
            listaAziende.Add(azienda);
            azienda = new Aziende("Pinco SPA", "Biella", 15000, "IT");
            listaAziende.Add(azienda);

            //Ordino gli elementi della lista
            listaAziende = listaAziende.OrderByDescending(x => x.RagioneSociale).ThenBy(x => x.Bilancio).ToList();
            //OrderBy, Where... sono parole del linguaggio Linq che nelle liste
            //Determinano elementi "enumerati"

            //visualizzo
            foreach (var elemento in listaAziende)
            {
                Console.WriteLine($"Ragione Sociale: {elemento.RagioneSociale} Residenza: {elemento.Residenza}" +
                    $" Bilancio: {elemento.Bilancio} Tipologia: {elemento.Tipologia}");
            }

            //Ricerca le sole aziende di biella... due modi diversi:

            //1) Funzione lista.. FindAll
            List<Aziende> aziendeBiellesi = new List<Aziende>();
            aziendeBiellesi = listaAziende.FindAll(x => x.Residenza.ToLower() == "biella");

            //visualizzo le aziende biellesi
            Console.WriteLine("Biellesi con FindAll");
            foreach (var elemento in aziendeBiellesi)
            {
                Console.WriteLine($"Ragione Sociale: {elemento.RagioneSociale} Residenza: {elemento.Residenza}" +
                    $" Bilancio: {elemento.Bilancio} Tipologia: {elemento.Tipologia}");
            }

            //2) con funzione della libreria List.. Where
            List<Aziende> aziendeBiellesi2 = new List<Aziende>();
            aziendeBiellesi2 = listaAziende.Where(x => x.Residenza.ToLower() == "biella").ToList();

            //visualizzo le aziende biellesi
            Console.WriteLine("Biellesi con Where");
            foreach (var elemento in aziendeBiellesi2)
            {
                Console.WriteLine($"Ragione Sociale: {elemento.RagioneSociale} Residenza: {elemento.Residenza}" +
                    $" Bilancio: {elemento.Bilancio} Tipologia: {elemento.Tipologia}");
            }

            //Cercare le aziede più ricche

            double massimoBilancio = listaAziende.Max(x => x.Bilancio);

            List<Aziende> AziendeRicche = new List<Aziende>();
            AziendeRicche = listaAziende.FindAll(x => x.Bilancio == massimoBilancio);
            // AziendeRicche = listaAziende.Where(x => x.Bilancio == massimoBilancio).ToList();
            Console.WriteLine("Aziende Ricche");
            foreach (var elemento in AziendeRicche)
            {
                Console.WriteLine($"Ragione Sociale: {elemento.RagioneSociale} Residenza: {elemento.Residenza}" +
                    $" Bilancio: {elemento.Bilancio} Tipologia: {elemento.Tipologia}");
            }

            //Media del bilancio
            double mediaBilancio = listaAziende.Average(x => x.Bilancio);
            //Con Math.Round approssimo il valore con un numero fisso di cifre decimali
            Console.WriteLine($"La media del Bilancio è: {Math.Round(mediaBilancio, 2)}");

            //Rimuovo tutte le aziende biellesi
            listaAziende.RemoveAll(x => x.Residenza.ToLower() == "biella");
            Console.WriteLine("Rimuovo Biella");
            foreach (var elemento in listaAziende)
            {
                Console.WriteLine($"Ragione Sociale: {elemento.RagioneSociale} Residenza: {elemento.Residenza}" +
                    $" Bilancio: {elemento.Bilancio} Tipologia: {elemento.Tipologia}");
            }
        }
    }
}
