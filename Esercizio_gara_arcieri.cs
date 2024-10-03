using System.Reflection.Metadata;

namespace Esercizio_Gara_arcieri
{
    public class Program
    {
        static void Main()
        {
            String P1;
            String P2;
            Console.WriteLine("Selezionare il nome del primo giocatore");
            P1 = Console.ReadLine();
            while (P1 == String.Empty)
            {
                Console.WriteLine("Inserire un nome valido per il primo giocatore");
                P1 = Console.ReadLine();
            }
            Console.WriteLine("Selezionare il nome del secondo giocatore");
            P2 = Console.ReadLine();
            while (P2 == String.Empty)
            {
                Console.WriteLine("Inserire un nome valido per il primo giocatore");
                P2 = Console.ReadLine();
            }
            int punteggioVittoria;
            Console.WriteLine("Inserire il punteggio per la vittoria fra: 30, 60, 90");
            while (!(int.TryParse(Console.ReadLine(), out punteggioVittoria) && punteggioVittoria == 30 || punteggioVittoria == 60 || punteggioVittoria == 90))
            {
                Console.WriteLine("Inserire uno dei valori validi: 30, 60, 90");
            }
            Random randValue = new Random();
            int punteggio1Fin = 0;
            int punteggio2Fin = 0;
            int tiro1;
            int tiro2;
            for (int partita = 1; punteggio1Fin <= punteggioVittoria && punteggio2Fin <= punteggioVittoria; partita++)
            {
                Console.WriteLine(); 
                Console.WriteLine();
                Console.WriteLine($"Partita numero {partita}");
                Thread.Sleep(1000);
                Console.WriteLine("I arcieri hanno tirato!");
                tiro1 = randValue.Next(1, 11);
                tiro2 = randValue.Next(1, 11);
                Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine($"{P1} ha fatto {tiro1} punti!");
                Console.WriteLine($"{P2} ha fatto {tiro2} punti!");
                punteggio1Fin = punteggio1Fin + tiro1;
                punteggio2Fin = punteggio2Fin + tiro2;
            }
            Console.WriteLine();
            Console.WriteLine($"{P1} ha fatto {punteggio1Fin} punti!");
            Console.WriteLine($"{P2} ha fatto {punteggio2Fin} punti!");
            if (punteggio1Fin > punteggio2Fin)
            {
                Console.WriteLine($"{P1} ha vinto!");
            }
            else if (punteggio1Fin < punteggio2Fin)
            {
                Console.WriteLine($"{P2} ha vinto!");
            }
            else
            {
                Console.WriteLine("entrambi i giocatori hanno pareggiato");
            }


        }
    }
}
