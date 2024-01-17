using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi_MAUI_6._0
{
    public class Matematica
    {
        public static double Delta(double a, double b, double c)
        {
            try
            {
                double risultato;

                risultato = Math.Pow(b, 2) - 4 * a * c;

                return risultato;
            }
            catch
            {
                throw new Exception("Errore nei parametri");
            }
        }

        public static void Equazione2Grado(double a, double b, double c, ref string messaggio, ref double x1, ref double x2)
        {
            try
            {
                if (Delta(a, b, c) > 0)
                {
                    messaggio = "Vi sono due radici reali e distinte";
                    x1 = (-b + Math.Sqrt(Delta(a, b, c))) / (2 * a);
                    x2 = (-b - Math.Sqrt(Delta(a, b, c))) / (2 * a);
                }
                else if (Delta(a, b, c) == 0)
                {
                    messaggio = "Vi sono due radici reali e coincidenti";
                    x1 = -b / (2 * a);
                    x2 = -b / (2 * a);
                }
                else
                {
                    messaggio = "Non ammette radici reali";
                    x1 = 0;
                    x2 = 0;
                }
            }
            catch
            {
                throw new Exception("Errore nei parametri");
            }
        }
    }
}
