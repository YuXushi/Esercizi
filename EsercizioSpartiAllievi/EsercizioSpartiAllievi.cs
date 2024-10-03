using System.Runtime.CompilerServices;

namespace EsercizioSpartiAllievi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int posAllievi = 1;
            string Scrivania = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(Scrivania, "voti.txt");
            if (File.Exists(filePath))
            {
                Console.WriteLine("-------------------------------------------");
                string recuperoFilePath = Path.Combine(Scrivania, "recupero.txt");
                string eccellenzeFilePath = Path.Combine(Scrivania, "eccellenze.txt");    
                StreamReader leggiFile = new StreamReader(filePath);
                StreamWriter scriviRecupero = new StreamWriter(recuperoFilePath);
                StreamWriter scriviEccellenze = new StreamWriter(eccellenzeFilePath);
                string leggiRiga; int voto;
                while (!leggiFile.EndOfStream)
                {
                    leggiRiga = leggiFile.ReadLine();
                    Console.WriteLine($"Posizione allievo: {posAllievi}." + '\n' + $"Voto allievo: {leggiRiga}.");
                    
                    voto = int.Parse(leggiRiga);
                    if (voto < 6)
                    {
                        Console.WriteLine("Condizione dell'allievo: Insufficiente.");
                        Console.WriteLine("programma: Recupero.");
                        scriviRecupero.WriteLine(posAllievi);
                    }
                    else if (voto >= 6 && voto < 8)
                    {
                        Console.WriteLine("Condizione dell'allievo: Sufficiente.");
                        Console.WriteLine("programma: N/A.");
                    }
                    else if (voto >= 8)
                    {
                        Console.WriteLine("Condizione dell'allievo: Eccellente.");
                        Console.WriteLine("programma: N/A.");
                        scriviEccellenze.WriteLine(posAllievi);
                    }
                    else
                    {
                        Console.WriteLine("Il voto dell'allievo presenta un errore, è sicuro di aver messo il voto giusto?");
                    }
                    Console.WriteLine("-------------------------------------------");
                    posAllievi++;
                }
                leggiFile.Close(); scriviEccellenze.Close(); scriviRecupero.Close();
            }
            else
            {
                Console.WriteLine("Il file 'voti.txt' non è presente nel desktop");
            }
        }
    }
}
