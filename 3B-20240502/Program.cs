namespace _3B_20240502
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime dn = new DateTime(2007, 12, 04);
            //Studente s1 = new("BITF01000Q", "3BINF INFORMATICA", "BAGAG", "ZAKARIA", dn, 'M', 5);
            //Console.WriteLine(s1.ToString());

            string nomeDir = @"C:\Users\moheb\source\repos\3B-20240502"; // Percorso del file
            string nomeFile = @"studenti.csv"; // Nome del file .csv da cui leggere i dati
            string nomeFileScritto = @"studentiScritto.csv"; // Nome del file .csv su cui salvare i dati
            string fullPath = Path.Combine(nomeDir, nomeFile); // Combinazione per creare il percorso completo
            Studente[] studenti; // array di tipo Studente per caricare i dati
            int contaRighe = 0;

            using (StreamReader sr = File.OpenText(fullPath)) // Apriamo il file
            {
                string rigaLetta = "";
                rigaLetta = sr.ReadLine(); // Leggiamo la prima riga
                while ((rigaLetta = sr.ReadLine()) != null) // Finché la riga letta non è vuota
                {
                    contaRighe++; // Contiamo le righe del file
                }
            }

            studenti = new Studente[contaRighe]; // Diamo la lunghezza al nostro array di tipo Studente

            using (StreamReader sr = File.OpenText(fullPath)) // Apriamo nuovamente il file
            {
                string rigaLetta = "";
                rigaLetta = sr.ReadLine(); // Leggiamo la prima riga
                int i = 0; // Indice che ci servirà per scorrere nell'array di tipo Studente
                while ((rigaLetta = sr.ReadLine()) != null) // Finché la riga letta non è vuota
                {   // In un array di stringhe andiamo a mettere i dati da ogni riga letta,
                    // separati dal punto e virgola.
                    string[] arrayDiStringhe = rigaLetta.Split(';');

                    // Nell'array di tipo Studente andiamo a memorizzare i dati presi dall'array di stringhe
                    studenti[i] = new Studente(arrayDiStringhe[0], arrayDiStringhe[1],
                                               arrayDiStringhe[2], arrayDiStringhe[3],
                                               DateTime.Parse(arrayDiStringhe[4]), // converto da stringa a DateTime
                                               char.Parse(arrayDiStringhe[5]), // converto da stringa in char
                                               Convert.ToDouble(arrayDiStringhe[6])); // converto da stringa in double
                    i++;
                }

                // Stampiamo gli studenti a video col metodo statico ToString
                foreach (Studente studente in studenti)
                {
                    Console.WriteLine(studente.ToString());
                }


                // Ordiniamo l'array studenti col BubbleSort
                BubbleSort(studenti);
                Console.WriteLine(new String('-', 40));

                // Cambiamo il percorso completo, modificando il file su cui andare a scrivere
                fullPath = Path.Combine(nomeDir, nomeFileScritto);

                // Creiamo un oggetto di tipo StreamWriter per scrivere i dati su un file
                using (StreamWriter sw = new StreamWriter(fullPath))
                {   // Stampiamo a video e scriviamo sul file, sempre col metodo ToString
                    foreach (var studente in studenti)
                    {
                        Console.WriteLine(studente.ToString());
                        sw.WriteLine(studente.ToString());
                    }
                }
            }

        }

        public static void BubbleSort(Studente[] studenti)
        {
            bool scambio = false;
            do
            {
                scambio = false;
                for (int i = 0; i < studenti.Length - 1; i++)
                {
                    if (studenti[i].QuestoMaggioreDi(studenti[i + 1]))
                    {
                        Scambia(studenti, i, i + 1);
                        scambio = true;
                    }
                }
            }
            while (scambio);
        }

        public static void Scambia(Studente[] studenti, int a, int b)
        {
            Studente tmp = studenti[a];
            studenti[a] = studenti[b];
            studenti[b] = tmp;
        }
    }
}