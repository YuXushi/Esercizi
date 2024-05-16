namespace EsercizioTrovaNumeri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Scrivania = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(Scrivania, "caratteri.txt");
            if (File.Exists(filePath))
            {
                string writeFileName = Path.Combine(Scrivania, "numeri.txt");
                StreamReader leggiRiga = new StreamReader(filePath);
                string riga;
                StreamWriter scriviRiga = new StreamWriter(writeFileName);
                while (!leggiRiga.EndOfStream)
                {
                    int test = 0;
                    riga = leggiRiga.ReadLine();
                    if (int.TryParse(riga, out test) && test >= 0 && test <= 9) 
                    {
                        scriviRiga.WriteLine(riga);
                        Console.WriteLine($"Scritto carattere: {riga}");
                    }
                }
                leggiRiga.Close();
                scriviRiga.Close();
            }
            else
            {
                Console.WriteLine("Il file 'caratteri.txt' non esiste");
            }

        }
    }
}
