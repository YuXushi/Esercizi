namespace FileSemplice
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //esempio percorso file usato come stringa
            //o si usa il doppio backslash (\\)
            //o si mette la @ davanti alla stringa
            //string filePercorso = "C:\\Users\\Xuxiang.yu\\Desktop";
            //string filePercorso2 = @"C:\Users\Xuxiang.yu\Desktop";

            // trovo il percorso Desktop
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //Vecchio modo
            //Console.WriteLine(desktop);
            //string nomeFileProva = desktop + "\\dati1.txt";

            string nomeFile1 = Path.Combine(desktop, "dati1.txt");
            string nomeFile2 = Path.Combine(desktop, "dati2.txt");

            //Scrittura con cancellazione del vecchio file
            StreamWriter sw = new StreamWriter(nomeFile1);
            string frase1 = "CIAO";
            string frase2 = "amici";
            sw.WriteLine(frase1);
            sw.WriteLine(frase2);
            sw.Close();

            //Scrittura con aggiunta
            StreamWriter sw1 = new StreamWriter(nomeFile2);
            string frase3 = "ripeti3";
            string frase4 = "ripeti4";
            sw1.WriteLine(frase3);
            sw1.WriteLine(frase4);
            sw1.Close();

            // Lettura  dal file 
            if (File.Exists(nomeFile2))
            {

                StreamReader sr = new StreamReader(nomeFile2);

                string linea;

                linea = "";
                while (linea != null)
                {
                    linea = sr.ReadLine();
                    Console.WriteLine(linea);
                }
                sr.Close();

            }


            //Esercizio
            /*
            Creare un file testo su un blocco note
            e inserite dei nomi, uno per linea. Esempio:
            Giulio
            Marco
            Massimo
            Marco
            Luca
            Marco

            Cercare se è presente un nome (scelto dall'utente) e contare queate volte è presente
            */
            string FileNomi = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Nomi.txt");
            Console.WriteLine("Inserire un nome da cercare nel file Nomi.");
            string nomeDaCercare = Console.ReadLine();
            while (nomeDaCercare.Trim().Length == 0)
            {
                Console.WriteLine("Inserire un nome da cercare nel file Nomi.");
                nomeDaCercare = Console.ReadLine();
            }
            if (File.Exists(FileNomi))
            {
                int conta = 0;
                StreamReader streamReader = new StreamReader(FileNomi);
                string testo = "";
                while (!streamReader.EndOfStream)
                {
                    testo = streamReader.ReadLine();
                    if (testo != null && testo.ToLower() == nomeDaCercare.ToLower())
                    {
                        conta++;
                    }
                }
                streamReader.Close();
                if (conta == 0)
                {
                    Console.WriteLine($"Il nome {nomeDaCercare} non è presente nel file Nomi.txt");
                }
                else
                {
                    Console.WriteLine($"Il nome {nomeDaCercare} è presente {conta} volte nel file Nomi.txt");
                }
            }
            else
            {
                Console.WriteLine("Il file Nomi.txt non esiste");
            }

        }
    }
}
