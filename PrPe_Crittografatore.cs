namespace PrPe_Crittografatore
{
    internal class Program
    {
        static void Main()
        {
            int chiave;
            Console.WriteLine("Inserisci la chiave della crittografia");
            while (!int.TryParse(Console.ReadLine(), out chiave))
            {
                Console.WriteLine("Inserire una chiave valida");
            }
            Console.WriteLine("vuoi crittografare o decrittografare? Inserisci C per crittografare, inserisci D per decrittografare [C/D]");
            string placeholder = Console.ReadLine().ToLower();
            char[] character = placeholder.ToCharArray();

            char A = 'A';
            int a = 1;
            char B = 'B';
            int b = 2;
            char C = 'C';
            int c = 3;
            char D = 'D';
            int d = 4;
            char E = 'E';
            int e = 5;
            char F = 'F';
            int f = 6;
            char G = 'G';
            int g = 7;
            char H = 'H';
            int h = 8;
            char I = 'I';
            int i = 9;
            char L = 'L';
            int l = 10;
            char M = 'M';
            int m = 11;
            char N = 'N';
            int n = 12;
            char O = 'O';
            int o = 13;
            char P = 'P';
            int p = 14;
            char R = 'R';
            int r = 15;
            char S = 'S';
            int s = 16;
            char T = 'T';
            int t = 17;
            char U = 'U';
            int u = 18;
            char V = 'V';
            int v = 19;
            char W = 'W';
            int w = 20;
            char X = 'X';
            int x = 21;
            char Z = 'Z';
            int z = 22;
            char SPAZIO = ' ';
            int spazio = 23;





        }
    }
}
