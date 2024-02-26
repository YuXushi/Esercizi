using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Esercizio_Vettori_Voti_2
{
    internal class Program
    {

        private static void Main()
        {
            bool restart = true;
            while (restart == true)
            {

                int[] vettore;
                int numeroVoti;

                chiediNumero();
                caricaVoti();
                visualizzaVettore();
                Console.WriteLine();
                scegli();
                void chiediNumero()
                {
                    Console.WriteLine("Indicare numero di allievi");
                    while (!int.TryParse(Console.ReadLine(), out numeroVoti) || numeroVoti <= 0)
                    {
                        Console.WriteLine("Indicare un numero maggiore di 0");
                    }
                    Console.WriteLine();
                    vettore = new int[numeroVoti];
                }
                void calcolaMedia()
                {
                    int media = 0;
                    for (int i = 0; i < vettore.Length; i++)
                    {
                        media += vettore[i];
                    }
                    media /= numeroVoti;
                    Console.WriteLine($"La media della class è {media}");
                }
                void trovaInsufficienze()
                {
                    Console.WriteLine("I allievi che sono insufficienti sono i allievi numero:");
                    for (int i = 0; i < vettore.Length; i++)
                    {
                        if (vettore[i] <= 5)
                        {
                            Console.Write($"{i + 1}; ");
                        }
                    }

                }
                void caricaVoti()
                {
                    Random random = new Random();
                    for (int i = 0; i < vettore.Length; i++)
                    {
                        vettore[i] = random.Next(2, 11);
                    }
                }
                void visualizzaVettore()
                {
                    if (numeroVoti < 20)
                    {
                        for (int i = 0; i < numeroVoti; i++)
                        {
                            Console.WriteLine($"{i + 1}. {vettore[i]}");
                        }
                    }
                    else if (numeroVoti >= 20)
                    {
                        for (int i = 0; i < numeroVoti; i++)
                        {
                            Console.Write($"{i + 1}. {vettore[i]}; ");
                        }
                    }
                }
                void scegli()
                {
                    int scelta;
                    Console.WriteLine("Selezionare una delle seguenti opzioni: ");
                    Console.WriteLine("Calcolare la media [1]");
                    Console.WriteLine("Trovare i allievi che hanno insufficienza [2]");
                    Console.WriteLine("Indicare la posizione degli allievi che hanno il voto più alto [3]");
                    Console.WriteLine();
                    while (!(int.TryParse(Console.ReadLine(), out scelta)) || scelta <= 0 || scelta >= 4)
                    {
                        Console.WriteLine("Inserire una opzione valida.");
                    }
                    if (scelta == 1)
                    {
                        calcolaMedia();
                    }
                    else if (scelta == 2)
                    {
                        trovaInsufficienze();
                    }
                    else if (scelta == 3)
                    {
                        trovaBravo();
                    }
                }
                void trovaBravo()
                {
                    int VotoMax = vettore[0];

                    for (int i = 1; i < vettore.Length; i++)
                    {
                        if (vettore[i] > VotoMax)
                        {
                            VotoMax = vettore[i];
                        }

                    }
                    Console.WriteLine("Allievi con voto massimo:");
                    for (int i = 0; i < vettore.Length; i++)
                    {
                        if (vettore[i] == VotoMax)
                        {
                            Console.WriteLine($"allievo n. {i + 1}");
                        }
                    }
                }
                char restar;
                Console.WriteLine("si desidera tornare alla selezione?[y/n]");
                restar = Console.ReadLine().ToLower()[0];
                if (restar == 'y')
                {
                    
                }
                else if (restar == 'n')
                {
                    restart = false;
                }
            }
        }
    }
}
