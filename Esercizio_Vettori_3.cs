namespace Esercizio_Vettori_3
{
    internal class Program
    {
        static void Main()
        {
            int dimensione;
            Console.WriteLine("Inserire la dimensione del vettore");
            while (!(int.TryParse(Console.ReadLine(), out dimensione)) || dimensione < 0)
            {
                Console.WriteLine("Inserire un valore valido e maggiore di 0");
            }
            int[] vettori = new int[dimensione];
            Random casuale = new Random();
            bool restart = true;
            while (restart == true)
            {
                ordinaVettore();
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
                if (totalePari == 0)
                {
                    Console.WriteLine("Non esistono numeri pari all'interno del vettore");
                }
                else
                {
                    Console.WriteLine($"La media dei numeri pari del vettore è: {sommaPari / totalePari}.");
                }
                if (totaleDispari == 0 )
                {
                    Console.WriteLine("Non esistono numeri dispari all'interno del vettore");
                }
                else
                {
                    Console.WriteLine($"La media dei numeri dispari del vettore è: {sommaDispari / totaleDispari}.");
                }
                
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
                int trovaMin = vettori[0]; // mette l'intero di trovaMin come il primo numero del vettore.
                for (int i = 0; i < vettori.Length; i++) //Questo ciclo for praticamente guarda tutto il vettore.
                {
                    if (trovaMin > vettori[i]) //Questo if controlla se trovaMin è maggiore (quindi non il più piccolo numero del vettore) del vettore, se è maggiore.
                    {
                        trovaMin = vettori[i]; //allora diventa il vettore (diventanto più piccolo),
                    } //Così trova il valore minimo del vettore.
                }
                int contaMin = 0;
                for (int i = 0; i < vettori.Length; i++) //Questo ciclo for scorre il vettore di nuovo.
                {
                    if (trovaMin == vettori[i]) //Quì controlla se nel vettore ha il numero minimo.
                    {
                        contaMin++; //Aumenta di 1 se trova  un valore minimo.
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
            void ordinaVettore()
            {
                int[] vettoreAusiliare = new int[dimensione];
                for (int i = 0; i < vettori.Length; i++)
                {
                    vettoreAusiliare[i] = vettori[i];
                }

                int temp;
                for (int i = 0; i < vettori.Length - 1;i++)
                {
                    for(int j = 0; j < vettori.Length;j++)
                    {
                        if (vettoreAusiliare[i] > vettoreAusiliare[j])
                        {
                            temp = vettoreAusiliare[i];
                            vettoreAusiliare[i] = vettoreAusiliare[j];
                            vettoreAusiliare[j] = temp;
                        }
                    }
                }
                for (int i = 0;i < vettori.Length;i++)
                {
                    Console.Write(vettoreAusiliare[i]);
                }
            }
        }
    }
}
