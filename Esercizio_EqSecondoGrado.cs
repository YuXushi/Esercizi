namespace Esercizio_EqSecondoGrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            Console.WriteLine("Esempio Equazione di Secondo Grado: ax^2 + bx + c");
            Console.WriteLine();
            Console.WriteLine("Dammi il coefficiente 'a' dell'equazione di secondo grado");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Inserire un valore valido");
                Console.WriteLine("Dammil il coefficiente 'a' dell'equazione di secondo grado:");
                Console.WriteLine("ax^2 + bx + c");
            }
            Console.WriteLine($"Valore 'a' inserito: {a}");
            Console.WriteLine($"Equazione: {a}x^2 + bx + c");
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine("Dammi il coefficiente 'b' dell'equazione di secondo grado");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Inserire un valore valido");
                Console.WriteLine("Dammil il coefficiente 'b' dell'equazione di secondo grado:");
                Console.WriteLine($"{a}x^2 + bx + c");
            }
            Console.WriteLine($"Valore 'b' inserito: {b}");
            Console.WriteLine($"Equazione: {a}x^2 + {b}x + c");
            Thread.Sleep(300);
            Console.WriteLine();
            Console.WriteLine("Dammi il coefficiente 'c' dell'equazione di secondo grado");
            while (!double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Inserire un valore valido");
                Console.WriteLine("Dammil il coefficiente 'c' dell'equazione di secondo grado:");
                Console.WriteLine($"{a}x^2 + {b}x + c");
            }
            Console.WriteLine($"Valore 'c' inserito: {c}");
            Console.WriteLine($"Equazione: {a}x^2 + {b}x + {c}");
            Thread.Sleep(300);
            Console.WriteLine();
            funzione2(a, b, c);
        }
        static double Delta(double a, double b, double c)
        {
            double risultato;
            risultato = Math.Pow(b, 2) - 4 * a * c;
            return risultato;
        }
        static void funzione2(double a, double b, double c)
        {
            if (Delta(a, b, c) > 0)
            {
                double x1 = (-b - Math.Sqrt(Delta(a, b, c)))/(2*a);

                double x2 = (-b + Math.Sqrt(Delta(a, b, c)))/(2*a);
                Console.WriteLine("Ha due radici reale e distinte:");
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (Delta(a, b, c) == 0)
            {
                double x1 = -b / (2*a);
                Console.WriteLine("Ha due radici reale e coincidenti:");
                Console.WriteLine($"x = {x1}");
            }
            else
            {
                Console.WriteLine("Non ha radici reali.");
            }
        }
        //è possibile copiare Delta e funzione2 in una nuova classe, cliccare con tasto destro "Esercizio_EqSecondoGrado"
        //aggiungi nuova classe, mettere su "public" in fronte dei static, poi tagliare Delta e funzione2 nella nuova classe, cambiando tutto a public
    }
}
/*
namespace Esercizio_EqSecondoGrado
{
    public class Program
    {
        static public void Main(string[] args)
        {
            bool restart = false;
            while (restart == false)
            {
                char Y;
                double a;
                double b;
                double c;
                Console.WriteLine("Esempio Equazione di Secondo Grado: ax^2 + bx + c");
                Console.WriteLine();
                Console.WriteLine("Dammi il coefficiente 'a' dell'equazione di secondo grado");
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Inserire un valore valido");
                    Console.WriteLine("Dammil il coefficiente 'a' dell'equazione di secondo grado:");
                    Console.WriteLine("ax^2 + bx + c");
                }
                Console.WriteLine($"Valore 'a' inserito: {a}");
                Console.WriteLine($"Equazione: {a}x^2 + bx + c");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.WriteLine("Dammi il coefficiente 'b' dell'equazione di secondo grado");
                while (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Inserire un valore valido");
                    Console.WriteLine("Dammil il coefficiente 'b' dell'equazione di secondo grado:");
                    Console.WriteLine($"{a}x^2 + bx + c");
                }
                Console.WriteLine($"Valore 'b' inserito: {b}");
                Console.WriteLine($"Equazione: {a}x^2 + {b}x + c");
                Thread.Sleep(300);
                Console.WriteLine();
                Console.WriteLine("Dammi il coefficiente 'c' dell'equazione di secondo grado");
                while (!double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Inserire un valore valido");
                    Console.WriteLine("Dammil il coefficiente 'c' dell'equazione di secondo grado:");
                    Console.WriteLine($"{a}x^2 + {b}x + c");
                }
                Console.WriteLine($"Valore 'c' inserito: {c}");
                Console.WriteLine($"Equazione: {a}x^2 + {b}x + {c}");
                Thread.Sleep(300);
                Console.WriteLine();
                Matematica.funzione2grado(a, b, c);

                Console.WriteLine("Vuoi ricominciare il programma? [Y/N]");
                while (!char.TryParse(Console.ReadLine().ToLower(), out Y))
                {
                    Console.WriteLine("Inserire Y o N, solo una lettera");
                }
                if (Y == 'y')
                {
                    restart = false;
                    Console.Clear();
                }
                else if (Y == 'n')
                {
                    restart = true;
                }
                else
                {
                    Console.WriteLine("Inserire Y o N");
                }
            }
        }
    }
}
*/
