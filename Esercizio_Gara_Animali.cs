internal class Program
{
    private static void Main()
    {
        string animale1;
        string animale2;
        int velocitàBase1;
        int velocitàBase2;
        int distanzaPercorsa1;
        int distanzaPercorsa2;
        int cronometro = 10;
        Console.WriteLine("inserisci il nome del primo amimale");
        animale1 = Console.ReadLine();
        Console.WriteLine($"animale 1 :{animale1}");
        Console.WriteLine("inserisci la velocità base del primo animale");
        while (!(int.TryParse(Console.ReadLine(), out velocitàBase1)))
        {
            Console.WriteLine("inserire un mumero valido");
        }

        Console.WriteLine("inserisci il nome del secondo amimale");
        animale2 = Console.ReadLine();
        Console.WriteLine($"animale 2 :{animale2}");
        Console.WriteLine("inserisci la velocità base del secondo animale");
        while (!(int.TryParse(Console.ReadLine(), out velocitàBase2)))
        {
            Console.WriteLine("inserire un mumero valido");
        }
        Console.WriteLine("inizia la gara");
        Random velocità1 = new Random();
        Random velocità2 = new Random();
        int distanza1 = 0;

        int distanza2 = 0;
        while (cronometro > 0)
        {
            Thread.Sleep(1000);
            cronometro--;
            Console.WriteLine($" {cronometro}");
            velocitàBase1 = velocitàBase1 + velocità1.Next(1, 11);
            velocitàBase2 = velocitàBase2 + velocità2.Next(1, 11);
            distanza1 = velocitàBase1 + distanza1;
            distanza2 = velocitàBase2 + distanza2;
            Console.WriteLine($"{animale1} ha percorso {distanza1} metri");
            Console.WriteLine($"{animale2} ha percorso {distanza2} metri");
            if (velocitàBase1 > velocitàBase2)
            {
                Console.WriteLine($"{animale1} guadagna terreno");
            }
            else if (velocitàBase1 < velocitàBase2)
            {
                Console.WriteLine($"{animale2} guadagna terreno");
            }
            else
            {
                Console.WriteLine($"{animale1} e {animale2} si equivalgono");
            }
        }
        Console.WriteLine("gara conclusa...");
        Thread.Sleep(1000);
        Console.WriteLine("classifica: ");
        if (distanza2 > distanza1)
        {
            Console.WriteLine($"1.{animale2}");
            Console.WriteLine($"2.{animale1}");

        }
        else if (distanza2 < distanza1)
        {
            Console.WriteLine($"1.{animale1}");
            Console.WriteLine($"2.{animale2}");
        }
        else
        {
            Console.WriteLine("pareggio");
        }
    }
}
