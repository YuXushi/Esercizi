namespace Esercizio_Vettori_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool reset = true;
            while (reset == true)
            {
                int[] numeri = new int[12];
                Random numRandom = new Random();
                for (int i = 0; i < numeri.Length; i++)
                {
                    numeri[i] = numRandom.Next(0, 10001);
                }
                string[] mesi = new string[12];
                mesi[0] = "Gennaio";
                mesi[1] = "Febbraio";
                mesi[2] = "Marzo";
                mesi[3] = "Aprile";
                mesi[4] = "Maggio";
                mesi[5] = "Giugno";
                mesi[6] = "Luglio";
                mesi[7] = "Agosto";
                mesi[8] = "Settembre";
                mesi[9] = "Ottobre";
                mesi[10] = "Novembre";
                mesi[11] = "Dicembre";

                Console.WriteLine("Guadagno di questo anno:");
                for (int i = 0; i < numeri.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine(mesi[i]);
                    Console.WriteLine($"{numeri[i]}$");
                }
                bool CalcoloReset = true;
                while (CalcoloReset == true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Scegliere una delle seguenti operazioni:");
                    Console.WriteLine("Inserire 1 per calcolare la media degli guadagni");
                    Console.WriteLine("Inserire 2 per contare quanti sono i mesi con un guadagno inferiore a 500");
                    Console.WriteLine("Inserire 3 per visualizzare i mesi con guadagno massimo");
                    int y = 0;
                    while (!(int.TryParse(Console.ReadLine(), out y)) || y < 1 || y > 3)
                    {
                        Console.WriteLine("Inserire un numero valido");
                    }
                    Console.WriteLine();
                    if (y == 1)
                    {
                        int somma = 0;
                        for (int i = 0; i < numeri.Length; i++)
                        {
                            somma += numeri[i];
                        }
                        Console.WriteLine($"Il guadagno medio è: {somma / numeri.Length}");
                    }
                    else if (y == 2)
                    {

                        int conta = 0;
                        for (int i = 0;i < numeri.Length; i++)
                        {
                            if (numeri[i] < 5000)
                            {
                                conta++;
                            }
                        }
                        Console.WriteLine($"Il numero di mesi in cui il guadagno è sotto i 5000 sono: {conta}");

                    }
                    else if (y == 3)
                    {
                        int temp;
                        int[] numeriTemp = new int[12];
                        for (int i = 0; i  < numeri.Length; i++)
                        {
                            numeriTemp[i] = numeri[i];
                        }
                        for (int i = 0; i < numeriTemp.Length; i++)
                        {
                            for (int k = 0; k < numeriTemp.Length; k++)
                            {
                                if (numeriTemp[i] > numeriTemp[k])
                                {

                                    temp = numeriTemp[i];
                                    numeriTemp[i] = numeriTemp[k];
                                    numeriTemp[k] = temp;

                                }
                            }
                        }
                        for ( int i = 0; i < numeriTemp.Length; i++)
                        {
                            Console.WriteLine(numeriTemp[i]);
                        }
                        int ricorda = 0;
                        for (int i = 0; i < numeriTemp.Length; i++)
                        {
                            for (int k = 0; k < numeri.Length; k++)
                            {

                                if (numeriTemp[i] == numeri[k])
                                {
                                    ricorda = k;
                                }
                            }
                        }
                        Console.WriteLine($"Il mese in cui ha dato più guadagno è: {mesi[ricorda]}");

                    }
                    Console.WriteLine();
                    Console.WriteLine("Vuoi Resettare il calcolo? [Y/N]");
                    char ResetC = Console.ReadLine().ToUpper()[0];
                    if (ResetC == 'Y')
                    {
                        Console.WriteLine("Resetting...");
                        Thread.Sleep(1000);
                    }
                    else if (ResetC == 'N')
                    {
                        Console.WriteLine("Closing...");
                        Thread.Sleep(1000);
                        CalcoloReset = false;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Vuoi Resettare la simulazione? [Y/N]");
                char RESET = Console.ReadLine().ToUpper()[0];
                if (RESET == 'Y')
                {
                    Console.WriteLine("Resetting...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else if (RESET == 'N')
                {
                    Console.WriteLine("Closing...");
                    Thread.Sleep(1000);
                    reset = false;
                }


            }
        }
    }
}
