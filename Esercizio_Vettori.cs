using System;

namespace Esercizio_Vettori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Carichiamo i voti di 5 verifiche:");
            Console.WriteLine("Calcolandone la media");*/
            //Dichiaro il vettore
            double numeroverifiche = 0;
            Console.WriteLine("Inserisci il numero di verifiche che si vuole inserire.");
            Console.WriteLine("Non oltre 100 verifiche");
            numeroverifiche = int.Parse(Console.ReadLine());
            while (numeroverifiche > 100)
            {
                Console.WriteLine("Il numero di verifiche è maggiore di 100, inserire un nuovo numero");
                numeroverifiche = int.Parse(Console.ReadLine());
            }

            double[] verifiche = new double[10]; //La [] di new double rappresenta quanti valori il vettore può contenere
            //Carico i Voti, ovvero carico i dati sul vettore
            for (int i = 0; i < verifiche.Length; i++)
            {
                Console.WriteLine($"Inserisci il voto n. {i + 1}");
                verifiche[i] = double.Parse(Console.ReadLine()); //Il primo cassetto della è nominato 0, non 1
            }
            double somma = 0;
            for (int i = 0; i < 5 ;i++)
            {
                somma += verifiche[i];
            }
            Console.WriteLine($"La media è {somma / verifiche.Length}");


            //-----------------------------------------------------------------------------------------------------------------



            // dichiaro un vettore di interi con dimensione 10

            int[] vettore = new int[10];

            //Carico il vettore con 10 numeri casuali compresi tra 0,100

            Random numeroCasuale = new Random();
            for (int i = 0; i < vettore.Length; i++)
            {
                vettore[i] = numeroCasuale.Next(0, 101);
            }

            //visualizzo il vettore
            Console.WriteLine("Il vettore casuale:");
            for (int i = 0; i < vettore.Length; i++)
            {
                Console.WriteLine(vettore[i]);
            }

            //Conteggio e ricerca di valori 
            // Contare quanti sono i valori < 50.
            int conta = 0;
            for (int i = 0; i < vettore.Length; i++)
            {
                if (vettore[i] < 50)
                {
                    conta++;
                }
            }
            Console.WriteLine($"i numeri minori di 50 sono: {conta}");

            // ordino i vettori in modo crescente

            int temp;
            for (int i = 0; i < vettore.Length - 1 ;i++)
            {
                for (int k = 0; k < vettore.Length ; k++)
                {
                    if (vettore[i] > vettore[k])
                    {
                        //scambio i valori
                        temp = vettore[k];
                        vettore[i] = vettore[k];
                        vettore[k] = temp;


                    }
                }
            }
            //Visualizzio di nuovo il vettore
            Console.WriteLine("il vettore ordinato");
            for ( int i = 0;i < vettore.Length; i++)
            {
                Console.WriteLine(vettore[i]);
            }
        }
    }
}
