namespace Esercizio_Funzioni_Vettori
{
  public class Program
    {
       public static void Main(string[] args)
        {
            //funzione per la stampa del vettore
            int[] Vettore = { 123, 45, 678, 149, 898 };
            static void StampaVettore(int[] vettore)
            {
                foreach (int i in vettore)
                {
                    Console.WriteLine(i);
                }
            }
            //funzione per la somma del vettore
            static void SommaVettore(int[] vettore)
            {
                int somma = 0;
                for (int i = 0; i < vettore.Length; i++)
                {
                   somma += vettore[i];
                    vettore[i] = somma;
                }
                StampaVettore(vettore);
            }
            Console.WriteLine("somma del vettore :");
            SommaVettore(Vettore);
            //ricerca del valore massimo
            static void TrovaMax(int[] vettore)
            {
                int ValoreMassimo= 0;
 
                for (int i = 0; i < vettore.Length; i++)
                {
                    if (vettore[i] > ValoreMassimo)
                    {
                        ValoreMassimo  = vettore[i];
                    }
                }
 
                int[] risultato = { ValoreMassimo };
                StampaVettore(risultato);
            }
            Console.WriteLine("il valore massimo  del vettore è:");
            TrovaMax(Vettore);
            //ordine crescente
            static void OrdinaCresc(int[] vettore)
            {
                vettore = vettore.OrderBy(x => x).ToArray();
                StampaVettore(vettore);
            }
            Console.WriteLine("vettore ordinato in ordine crescente");
            OrdinaCresc(Vettore);
            //ordine decrescente
            static void OrdinaDesc(int[] vettore)
            {
                vettore = vettore.OrderByDescending(x => x).ToArray();
                StampaVettore(vettore);
            }
            Console.WriteLine("vettore ordinato in ordine decrescente");
            OrdinaDesc(Vettore);
 
            static void CercaNum(int[] vettore)
            {
                int cerca = 0;
                int[] risultato = new int[1];
                Console.WriteLine("ricerca di un numero all'interno del vettore( 1 = numero presente 2 = numero non presente)");
                Console.WriteLine("Inserire il numero da cercare: ");
                while (!(int.TryParse(Console.ReadLine(), out cerca))) 
                { 
                    Console.WriteLine("il valore inserito non è valido"); 
                }
 
                if (vettore.Contains(cerca))
                {
                    risultato[0] = 1;
                }
                else
                {
                    risultato[0] = 0;
                }
 
                StampaVettore(risultato);
            }
            CercaNum(Vettore);
 
       }
    }
}
