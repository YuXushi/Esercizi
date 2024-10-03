internal class Program
{
    private static void Main()
    {
        string animale2;
        int velocitàBase1;
        int distanza1 = 0;
        int velocitàBase2;
        int distanza2 = 0;
        string animale1;
        Console.WriteLine("Inserisci il nome del primo animale");
        animale1 = Console.ReadLine();
        Console.WriteLine("Inserire un numero intero come la velocità base del secondo animale");
        while (!(int.TryParse(Console.ReadLine(), out velocitàBase1) && velocitàBase1 > 0))
        {
            Console.WriteLine("Inserire un numero valido, prego");
        }
        Console.WriteLine("Inserisci il nome del secondo animale");
        animale2 = Console.ReadLine();
        Console.WriteLine("Inserire un numero intero come la velocità base del secondo animale");
        while (!(int.TryParse(Console.ReadLine(), out velocitàBase2) && velocitàBase1 > 0))
        {
            Console.WriteLine("Inserire un numero valido, prego");
        }
        Console.WriteLine($"Nome del primo animale: {animale1}");
        Console.WriteLine($"Nome del secondo animale: {animale2}");
        Console.WriteLine($"Velocità del primo animale: {velocitàBase1} metri al secondo");
        Console.WriteLine($"Velocità del secondo animale: {velocitàBase2} metri al secondo");
        Random velocità1 = new Random();
        Random velocità2 = new Random();
        int Cronometro = 0;
        while (Cronometro < 10) 
        {
            Cronometro++;
            Thread.Sleep(1000);
            Console.WriteLine($"Siamo al secondo {Cronometro}");
            Console.WriteLine();
            velocitàBase1 = velocitàBase1 + velocità1.Next(1, 11);
            velocitàBase2 = velocitàBase2 + velocità2.Next(1, 11);
            Console.WriteLine($"La velocità di {animale1} ha incrementato a {velocitàBase1} metri al secondo!");
            Console.WriteLine($"La velocità di {animale2} ha incrementato a {velocitàBase2} metri al secondo!");
            Console.WriteLine();
            distanza1 = distanza1 + velocitàBase1;
            distanza2 = distanza2 + velocitàBase2;
            Console.WriteLine($"{animale1} ha percorso {distanza1} metri");
            Console.WriteLine($"{animale2} ha percorso {distanza2} metri");
            Console.WriteLine();
            if(distanza1 > distanza2)
            {
                Console.WriteLine($"{animale1} stà prendendo più terreno di {animale2}");
            }
            else if(distanza1 < distanza2)
            {
                Console.WriteLine($"{animale2} stà prendendo più terreno di {animale1}");
            }
            else if (distanza2 == distanza1)
            {
                Console.WriteLine("Entrambi i animali sono alla stessa distanza!");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        Console.WriteLine("La gara si è conclusa!");
        if (distanza1 > distanza2)
        {
            Console.WriteLine($"{animale1} ha vinto la corsa!");
        }
        else if (distanza1 < distanza2)
        {
            Console.WriteLine($"{animale2} ha vinto la corsa!");
        }
        else if (distanza1 == distanza2)
        {
            Console.WriteLine("I animali hanno pareggiato");
        }
    }
}
