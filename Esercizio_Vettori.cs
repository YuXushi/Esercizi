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

            double[] verifiche = new double[numeroverifiche]; //La [] di new double rappresenta quanti valori il vettore può contenere
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




        }
    }
}
