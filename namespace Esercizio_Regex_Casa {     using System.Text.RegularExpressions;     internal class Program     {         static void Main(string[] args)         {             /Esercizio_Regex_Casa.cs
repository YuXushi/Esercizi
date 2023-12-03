namespace Esercizio_Regex_Casa
{
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            // nel testo c'è almeno una parola che è "alpha" o "ALPHA" e lo ridà
            string pattern = @"\b[alphaALPHA]\b";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            Match match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine("Match Found: " + match.Value);
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }
    }
}
