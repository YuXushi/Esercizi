using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Magazino
{
    public class classeProdotti
    {
        public string nomeProdotto { get; set; }
        public string Tipologia { get; set; }
        public string Fornitore { get; set; }
        public double prezzoUnitario { get; set; }
        public int quantitaMagazzino { get; set; }

        public classeProdotti()
        {
            nomeProdotto = "-";
            Tipologia = "-";
            Fornitore = "-";
            prezzoUnitario = 0;
            quantitaMagazzino = 0;
        }
        public classeProdotti(string nomeprodotto, string tipologia, string fornitore, double prezzounitario, int quantitamagazzino)
        {
            nomeProdotto = nomeprodotto;
            Tipologia = tipologia;
            Fornitore = fornitore;
            prezzoUnitario = prezzounitario;
            quantitaMagazzino = quantitamagazzino;
        }


    }
}
