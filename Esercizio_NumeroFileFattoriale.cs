namespace Esercizio_NumeroFileFattoriale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Scrivania = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = @"numero.txt";
            string path = Path.Combine(Scrivania, fileName);
            using (StreamReader reader = File.OpenText(path))
            {
                string readLine = reader.ReadLine();
                int numero = int.Parse(readLine);
                Console.WriteLine($"Numero Input: {numero}");
                Fattoriale(numero);
                while ((readLine = reader.ReadLine()) != null)
                {
                    numero = int.Parse(readLine);
                    Console.WriteLine($"Numero Input: {numero}");
                    Fattoriale(numero);
                }
            }
            string nomeFile = "fattoriale.txt";
            path = Path.Combine(Scrivania, nomeFile);

            using (StreamWriter writer = new StreamWriter(path))
            {





            }


        }

        static void Fattoriale(int input)
        {
            int origin = input;
            if (input == 0)
            {
                input = 1;
            }
            else
            {
                int auxiliar = input - 1;
                for (int i = 0; i < origin - 1; i++)
                {
                    input *= auxiliar;
                    auxiliar--;
                }
            }
            Console.WriteLine($"Il Fattoriale di {origin} è {input}");
        }
    }
}
