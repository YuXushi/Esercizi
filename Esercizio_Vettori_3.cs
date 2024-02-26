namespace Esercizio_Vettori_3
{
    internal class Program
    {
        static void Main()
        {
            int[] vettori = new int[50];
            Random casuale = new Random();
            bool restart = true;
            while (restart == true)
            {
                visualizzaVettore();
                Console.WriteLine();
                trovaPariDispari();
                Console.WriteLine();
                trovaMaggiorUguale();
                Console.WriteLine();
                trovaMin();
                Console.WriteLine();
                riparti();
                Console.WriteLine();
            }
            void visualizzaVettore()
            {
                Console.WriteLine("Il vettore è: ");
                for (int i = 0; i < vettori.Length; i++)
                {
                    vettori[i] = casuale.Next(1, 61);
                    Console.Write(vettori[i] + "; ");
                }
            }
            void trovaPariDispari()
            {
                int sommaPari = 0; int sommaDispari = 0; int totalePari = 0; int totaleDispari = 0;
                for (int i = 0; i < vettori.Length; i++)
                {
                    if (vettori[i] % 2 == 0)
                    {
                        sommaPari += vettori[i];
                        totalePari++;
                    }
                    else if (vettori[i] % 2 != 0)
                    {
                        sommaDispari += vettori[i];
                        totaleDispari++;
                    }
                }
                Console.WriteLine($"La media dei numeri pari del vettore è: {sommaPari / totalePari}.");
                Console.WriteLine($"La media dei numeri dispari del vettore è: {sommaDispari / totaleDispari}.");
            }
            void trovaMaggiorUguale()
            {
                int numero;
                Console.WriteLine("inserire un numero intero");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Inserire un numero valido intero.");
                }
                int contaMaggiorUguale = 0;
                for (int i = 0; i < vettori.Length; i++)
                {
                    if (numero <= vettori[i])
                    {
                        contaMaggiorUguale++;
                    }
                }
                Console.WriteLine($"I numeri maggiori o uguali a {numero} sono {contaMaggiorUguale}");
            }
            void trovaMin()
            {
                int trovaMin = vettori[0];
                for (int i = 0; i < vettori.Length; i++)
                {
                    if (trovaMin > vettori[i])
                    {
                        trovaMin = vettori[i];
                    }
                }
                int contaMin = 0;
                for (int i = 0; i < vettori.Length; i++)
                {
                    if (trovaMin == vettori[i])
                    {
                        contaMin++;
                    }
                }
                if (contaMin == 1)
                {
                    Console.WriteLine($"Il valore minimo del vettore è {trovaMin} ed è presente {contaMin} volta");
                }
                else if (contaMin > 1)
                {
                    Console.WriteLine($"Il valore minimo del vettore è {trovaMin} ed è presente {contaMin} volte");
                }
            }
            void riparti()
            {
                char scegli;
                bool restart2 = true;
                Console.WriteLine("Si desidera ripartire la simulazione? [Y/N]");
                while (restart2 == true)
                {
                    scegli = Console.ReadLine().ToLower()[0];
                    if (scegli == 'y')
                    {
                        restart = true;
                        restart2 = false;
                    }
                    else if (scegli == 'n')
                    {
                        restart = false;
                        restart2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Scegli Y o N");
                        restart2 = true;
                    }
                }
            }
        }
    }
}
