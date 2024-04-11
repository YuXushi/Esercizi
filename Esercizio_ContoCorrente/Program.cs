namespace Esercizio_ContoCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContoCorrente conto = new ContoCorrente(12345, "Mario Rossi", 1000);
            conto.StampaInformazioni();
            Console.WriteLine();
            Console.WriteLine("Deposito di 500");
            conto.Deposita(500);
            conto.StampaInformazioni();
            Console.WriteLine();
            Console.WriteLine("Prelievo di 200");
            conto.Preleva(200);
            conto.StampaInformazioni();
            Console.WriteLine();
            Console.WriteLine("Prelievo di 1500");
            conto.Preleva(1500);
            conto.StampaInformazioni();
            Console.WriteLine();
            Console.WriteLine("Deposito di -100");
            conto.Deposita(-100);
            conto.StampaInformazioni();
        }
    }
}

