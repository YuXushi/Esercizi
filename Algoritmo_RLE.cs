internal class program
{
    public static string calculaterlestring(string input)
    {
        //per accedre all'i-esimo carattere di na stringa
        int i = 0;
        char car;
        string ris;
        for (int j = 0; j < input.Length; j++)
        {
            car = input[i];
            if (car != input[j])
            {
                Console.Write(car);
            }
            else
            {


            }



            i++;
        }

        return "";
    }
    private static void Main(string[] args)
    {
        string testo = "AAAABAABBBCC";
        string risultato = calculaterlestring(testo);
        //mi aspetto che il risultato valga
        //4abb2a3b2c
    }
}
