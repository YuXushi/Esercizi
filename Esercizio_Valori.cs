using System.IO;

namespace Esercizio_Valori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String dt = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = Path.Combine(dt, "valori.txt");
            StreamWriter sw = new StreamWriter(file); 
            Random casuale = new Random();
            for (int i = 0; i < 20; i++)
            {
                sw.WriteLine(casuale.Next(1, 100));
            }
            sw.Close();
            if (File.Exists(file))
            {
                int contaMaggiore = 0;
                int contaPari = 0;
                StreamReader sr = new StreamReader(file);
                string line = "";
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    if (int.Parse(line) > 50)
                    {
                        contaMaggiore++;
                    }
                    if (int.Parse(line) % 2 == 0)
                    {
                        contaPari++;
                    }
                }
                sr.Close();
                Console.WriteLine($"Il numero di valori maggiori di 50 all'interno del file sono {contaMaggiore}.");
                Console.WriteLine($"Il numero di valori pari all'interno del file sono {contaPari}.");
            }
        }
    }
}
