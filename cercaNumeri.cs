namespace cercaNumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scrivania = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePercorso = Path.Combine(scrivania, "valori.txt");
            StreamReader fileLeggi = new StreamReader(filePercorso);
            string filePercorsoScrittura = Path.Combine(scrivania, "multipli.txt");
            StreamWriter fileScrivi = new StreamWriter(filePercorsoScrittura);
            if (File.Exists(filePercorso))
            {
                int contaCompreso = 0;
                while (!fileLeggi.EndOfStream)
                {
                    int valore = int.Parse(fileLeggi.ReadLine());
                    if (valore >= 5 && valore <= 15)
                    {
                        contaCompreso++;
                        fileScrivi.WriteLine(valore * 2);
                    }
                    else
                    {
                        fileScrivi.WriteLine(valore);
                    }
                }
                fileLeggi.Close(); fileScrivi.Close();
                Console.WriteLine($"I valori compresi tra 5 e 15 sono: {contaCompreso}");
            }
            else
            {
                Console.WriteLine("Il file 'valori.txt' non esiste");
            }
        }
    }
}

/*
Leggi da un file di testo ("valori.txt") su cui hai inserito 
(tramite blocco note) 10 numeri in verticale e conta quanti
sono i valori compresi tra 5 e 15.
Scrivi (con codice) un file "multipli.txt" dove riscrivi i
numeri precedenti, e quelli compresi tra 5 e 15 raddoppiati.
*/
