namespace Esercizio_Funzione_1
{
    internal class Program
    {
        static void Main(string[] args) // la funzione lascia che il programma può essere diviso
        {
            //double AreaRettangolo;
            Console.WriteLine("Inserisci la base");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci l'altezza");
            double a = double.Parse(Console.ReadLine());
            //AreaR(a, b, out area)
            //AreaR(a, b); //questo và a cercare nel void la funzione chiamata AreaR
            Console.WriteLine($"L'area del rettangolo è {AreaR(a, b)}");
            Console.WriteLine($"Il perimetro del rettangolo è {Perimetro(a, b)}");
        }
        static double AreaR(double x, double y)
        //static double AreaR(double x, double y, out double area)
        {
            //Funzione, la funzione è chiamata AreaR.
            //Void è una funzione vuota che non ritorna niente, fà il codice e basta.
            double risultato = 0;

            //per passare la variabile a e b ad AreaR, si deve specificarlo nella funzione di AreaR
            //dove si specifica il tipo di dato e il nome(che non deve necessariamente errese uguale)
            //poi, nel main si specifica quali dati si vuole essere passato in AreaR, e lo passa
            //quindi a = x, b = y per l'ordine in cui è stato inserito
            risultato = x * y;
            return risultato;
        } //per ritornare il valore area indietro, si può utilizzare out davanti ad entrambi le finzioni
        // out sta per riferimento, e si può utilizzare alternativamente ref
        static double Perimetro(double x, double y)
        {
            double risultato = 0;
            risultato = 2 * (x + y); // funzione per il perimetro invece :)
            return risultato;
        }
        static bool doubleConverti(string valoreDaConvertire, out double variabile)
        {
            bool risultato = false; // non chiedermi che cacchio serve questo T_T, e dove lo dà nel main
            try // ah, è solo un esempio
            {
                variabile = double.Parse(valoreDaConvertire);
                risultato = true;
                return risultato;
            }
            catch
            {
                variabile = 0;
                risultato = false;
                return risultato;
            }
        }
    }
}
//le altre funzioni come Double, Int etc... aspettano che tu ritorni un valore come return
