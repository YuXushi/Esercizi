namespace Esercizio_MiniGolf_21112023
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Inserire il nome del giocatore 1");
            string P1 = Console.ReadLine();
            while(string.IsNullOrEmpty(P1))
            {
                Console.WriteLine("Inserire un nome per continuare");
                P1 = Console.ReadLine();
            }
            Console.WriteLine("Inserire il nome del giocatore 2");
            string P2 = Console.ReadLine();
            while (string.IsNullOrEmpty(P2))
            {
                Console.WriteLine("Inserire un nome per continuare");
                P2 = Console.ReadLine();
            }
            Random vCasuale = new Random();
            int tiri1 = 0; int distanzaBuca = 0; int tiri2 = 0; int Dis1 = 0; int Dis2 = 0; int Punti1 = 0; int Punti2 = 0;
            for (int ContaTiri = 1; ContaTiri <= 9; ContaTiri += 1)
            {
                int tiro1 = 0; int tiro2 = 0;
                tiri1 = vCasuale.Next(1, 11); distanzaBuca = vCasuale.Next(1, 11);
                tiri2 = vCasuale.Next(1, 11); Console.WriteLine($"Partita numero {ContaTiri}.");
                Dis1 = distanzaBuca - tiri1; distanzaBuca = vCasuale.Next(1, 11); Dis2 = distanzaBuca - tiri2;
                if (Dis1 != 0)
                {
                while(Dis1 > 0)
                    {
                        tiri1 = vCasuale.Next(1, 11);
                        Dis1 = Dis1 - tiri1;
                        tiro1++;
                    }
                }
                if (Dis2 != 0)
                {
                    while (Dis2 > 0)
                    {
                        tiri2 = vCasuale.Next(1, 11);
                        Dis2 = Dis2 - tiri2;
                        tiro2++;
                    }
                }
            tiro1++;
            tiro2++;
                Thread.Sleep(1000);
                if (tiro1 == 1) 
                { 
                    Console.WriteLine($"{P1} Ha fatto {tiro1} tiro prima di fare buca!");
                } 
                else 
                { 
                    Console.WriteLine($"{P1} Ha fatto {tiro1} tiri prima di fare buca!");
                }
                if (tiro2 == 1)
                {
                    Console.WriteLine($"{P2} Ha fatto {tiro2} tiro prima di fare buca!");
                }
                else
                {
                    Console.WriteLine($"{P2} ha fatto {tiro2} tiri prima di fare buca!");
                }
                Punti1 += tiro1;
                Punti2 += tiro2;
                Thread.Sleep(2000);
            Console.WriteLine();
            }
            Console.WriteLine($"{P1} ha fatto {Punti1} Punti");
            Console.WriteLine($"{P2} ha fatto {Punti2} Punti");
            if (Punti1 < Punti2)
            {
                Console.WriteLine($"{P1} Ha vinto!");
            }
            else if (Punti1 > Punti2)
            {
                Console.WriteLine($"{P2} Ha vinto!");
            }
            else
            {
                Console.WriteLine("Entrambi i giocatori hanno pareggiato");
            }
        }
    }
}
