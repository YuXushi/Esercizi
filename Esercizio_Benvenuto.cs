/*

 Variant: 
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Inserire il Nome e Cognome");
            string Nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Inserire Quanti Anni ha");
            int Anno = int.Parse(Console.ReadLine());
            if (Anno < 0)
            {
                Console.WriteLine("Il Valore Inserito non è valido");
            }
            else if (Anno < 18)
            {
                Console.WriteLine("Il programma è programmato per utenti maggiori di 18 anni");
            }
            else if(Anno >= 18)
            {
                Console.WriteLine($"BENVENUTO " + Nome);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Il Valore Inserito non è valido       " + ex.Message);
        }
    }
}
*/

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Inserire il Nome e Cognome");
            string Nome = Console.ReadLine().ToUpper();
            Console.WriteLine("Inserire Anno di nascita");
            int Anno = int.Parse(Console.ReadLine());
            if (DateTime.Today.Year - Anno < 18)
            {
                Console.WriteLine("Il programma è programmato per utenti maggiori di 18 anni");
            }
            else if (DateTime.Today.Year - Anno >= 18)
            {
                Console.WriteLine($"BENVENUTO " + Nome);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Il Valore Inserito non è valido       " + ex.Message);
        }
    }
}
