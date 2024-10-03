using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_ContoCorrente
{
    public class ContoCorrente
    {
        public int IDConto {  get; set; }
        public string Titolare { get; set; }
        public double Saldo { get; set; }
        static int numConti {  get; set; }
        //{
        //    get { return saldo; }
        //    set
        //    {
        //        if (value - saldo >= 0)
        //        {
        //            value = saldo;
        //        }
        //        else
        //        {
        //            throw new Exception("");
        //        }
        //    }
        //}
        public ContoCorrente(int idConto, string titolare, double saldoIniziale)
        {
            IDConto = idConto;
            Titolare = titolare;
            Saldo = saldoIniziale;
            numConti++;
        }
        public void Deposita(double deposito)
        {
            double tot = Saldo + deposito;
            if (deposito < 0)
            {
                Console.WriteLine("Il deposito non è valido, inserire un numero positivo");
            }
            else
            {
                Saldo = tot;
            }
        }
        public void Preleva(double saldo)
        {
            double tot = Saldo - saldo;
            if (tot < 0) 
            {
                Console.WriteLine("Non è possibile fare il prelievo");
            }
            else
            {
                Saldo = tot;
            }
        }
        public void StampaInformazioni()
        {
            Console.WriteLine("ID Del Conto: " + IDConto);
            Console.WriteLine("Titolare del Conto: " + Titolare);
            Console.WriteLine("Saldo del Conto: " + Saldo);
        }
    }
}
