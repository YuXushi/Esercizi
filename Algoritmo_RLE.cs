internal class program
{
    public static string calculaterlestring(string input)
    {
        //per accedre all'i-esimo carattere di una stringa

        int j = 0;
        int y = 0;

        for (int i = 0; i < input.Length; i++)
        {
            j++;
            y++;
            if (j == input.Length)
            {
                if (y != 1)
                {
                    Console.Write(y);
                    Console.Write(input[i]);
                }
                else
                {
                    Console.Write(input[i]);
                    Console.Write(input[i]);
                }
                y = 0;
            }
            else if (input[i] != input[j])
            {
                if (y != 1)
                {
                    Console.Write(y);
                    Console.Write(input[i]);
                }
                else
                {
                    Console.Write(input[i]);
                    Console.Write(input[i]);
                }
                y = 0;
            }

        }
        return "";
    }
    private static void Main(string[] args)
    {
        string testo = "AAAABAABBBCC";
        string risultato = calculaterlestring(testo);
        //mi aspetto che il risultato valga
        //4ABB2A3B2C
    }
}
