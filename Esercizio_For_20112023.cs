namespace Esercizio_For_20112023
{
    //dato il numero n di alunni di una classe
    //chiedere il voto di matematica e di italiano
    //e calcolare la media sia di matematica
    //che di italiano

    public class Program
    {
        static void Main()
        {
            // data
            int n;
            Console.WriteLine("Quanti sono i alunni in una classe?");
            if (!(int.TryParse(Console.ReadLine(), out n) && n > 0))
            {
                Console.WriteLine("Inserisci un numero valido");
            }
            while (!int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                Console.WriteLine("inserire un numero valido");
            }
            double sommaMate = 0;
            double Voto = 0;
            double sommaIta = 0;
            for (int conta = 1; conta < n+1; conta+=1)
            {
                Console.WriteLine($"inserire il voto di matematica del alunno {conta}");
                if (!(int.TryParse(Console.ReadLine(), out n) && Voto >= 2 && Voto < 10))
                {
                    Console.WriteLine("Inserisci un voto valido");
                }
                while (!(double.TryParse(Console.ReadLine(), out Voto) && Voto >= 2 && Voto < 10))
                {
                    Console.WriteLine("Inserisci un voto valido");
                }
                sommaMate += Voto;
                Console.WriteLine($"inserire il voto di italiano del alunno {conta}");
                if (!(int.TryParse(Console.ReadLine(), out n) && Voto >= 2 && Voto < 10))
                {
                    Console.WriteLine("Inserisci un voto valido");
                }
                while (!(double.TryParse(Console.ReadLine(), out Voto) && Voto >= 2 && Voto < 10))
                {
                    Console.WriteLine("Inserisci un voto valido");
                }
                sommaIta += Voto;
            }
            sommaMate /= n;
            Console.WriteLine($"La media di matematica di {n} alunni è {sommaMate}");
            sommaIta /= n;
            Console.WriteLine($"La media di italiano di {n} alunni è {sommaIta}");
        }
    }
}
/*  Dato il numero n di alunni di una classe,
    chiedere il voto di matematica e di italiano
    e calcolare la media sia di matematica
    che di italiano



  public class Program
  {

      static void Main(string[] args)
      {
          try {
              int n; //numero allievi
              double votoItaliano;
              double votoMatematica;
              double sommaItaliano;
              double sommaMatematica;
              Console.WriteLine("Quanti allievi ci sono?");
              if (!(int.TryParse(Console.ReadLine(), out n) &&  n > 0) )
              {
                  Console.WriteLine("inserisci un valore corretto di allievi");
              }
              while (!(int.TryParse(Console.ReadLine(), out n) && n > 0)) 
              {
                  Console.WriteLine("bastardo!!! inserisci un valore corretto di allievi");
              }



              sommaItaliano = 0;
              sommaMatematica = 0;
              for (int conta = 0; conta < n; conta++)
              {
                  Console.WriteLine($"Voto di Italiano dell'allievo {conta + 1}?");
                  if (!(double.TryParse(Console.ReadLine(), out votoItaliano) && votoItaliano>=2 && votoItaliano<=10))
                  {
                      Console.WriteLine("inserisci un valore corretto del voto di Italiano");
                  }
                  while (!(double.TryParse(Console.ReadLine(), out votoItaliano) && votoItaliano >= 2 && votoItaliano <= 10))
                  {
                      Console.WriteLine("inserisci un valore corretto del voto di Italiano");
                  }

                  sommaItaliano += votoItaliano;
                  //sommaItaliano=sommaItaliano+votoItaliano;
                  Console.WriteLine($"Voto di Matematica dell'allievo {conta + 1}?");
                  votoMatematica = double.Parse(Console.ReadLine());
                  sommaMatematica += votoMatematica;
                  //sommaMatematica=sommaMatematica+votoMatematica;

              }
              Console.WriteLine($"La media di Italiano è {sommaItaliano / n}");
              Console.WriteLine($"La media di Matematica è {sommaMatematica / n}");
          }
          catch (Exception ex) 
          {
              Console.WriteLine(ex.Message);
          }
      }
  }
 
 */
