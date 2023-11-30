namespace Esercizio_premotazioneRistorante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomValue = new Random();
            int nTavoli2;
            int nTavoli4;
            int nTavoli6;
            int posti;
            int clienti;
            int contaClienti = 0;
            int contaPrenotazione = 0;
            Console.WriteLine("Quanti tavoli da 2 persone ci sono?");
            while (!(int.TryParse(Console.ReadLine(), out nTavoli2) && nTavoli2 >= 0))
            {
                Console.WriteLine("Inserire numero di tavoli maggiore o uguale di 0");
            }
            Console.WriteLine("Quanti tavoli da 4 persone ci sono?");
            while (!(int.TryParse(Console.ReadLine(), out nTavoli4) && nTavoli4 >= 0))
            {
                Console.WriteLine("Inserire numero di tavoli maggiore o uguale di 0");
            }
            Console.WriteLine("Quanti tavoli da 6 persone ci sono?");
            while (!(int.TryParse(Console.ReadLine(), out nTavoli6) && nTavoli6 >= 0))
            {
                Console.WriteLine("Inserire numero di tavoli maggiore o uguale di 0");
            }
            posti = nTavoli2 * 2 + nTavoli4 * 4 + nTavoli6 * 6;
            for (clienti = randomValue.Next(1, 7); posti! < 0 || posti != 0; contaClienti += clienti)
            {
                clienti = randomValue.Next(1, 7);
                contaPrenotazione++;
                Console.WriteLine($"Prenotazione Numero {contaPrenotazione}");
                if (contaClienti == 0)
                {
                    contaClienti = clienti;
                }
                Console.WriteLine($"Sono entrati {clienti} clienti");
                if (contaClienti == 1)
                {
                    Console.WriteLine($"al momento c'è un cliente nel ristorante");
                }
                else
                {
                    Console.WriteLine($"Ci sono al momento {contaClienti} clienti nel ristorante");
                }
                Console.WriteLine($"Ci sono al momento {contaClienti} clienti nel ristorante");
                if (clienti < 3 && nTavoli2 != 0)
                {
                    nTavoli2--;
                    Console.WriteLine("Siete stati assegnati a un tavolo da 2");
                }
                else if (clienti < 5 && nTavoli4 != 0)
                {
                    nTavoli4--;
                    Console.WriteLine("Siete stati assegnati a un tavolo da 4");
                }
                else if (clienti < 7 && nTavoli6 != 0)
                {
                    nTavoli6--;
                    Console.WriteLine("Siete stati assegnati a un tavolo da 6");
                }
                posti = nTavoli2 * 2 + nTavoli4 * 4 + nTavoli6 * 6;
                if (clienti < 7 && nTavoli6 == 0)
                {
                    Console.WriteLine("Non ci sono abbastanza posti");
                    posti = 0;
                }
                Console.WriteLine($"Numero di tavoli da 2: {nTavoli2}");
                Console.WriteLine($"Numero di tavoli da 4: {nTavoli4}");
                Console.WriteLine($"Numero di tavoli da 6: {nTavoli6}");
            }
        }
    }
}
