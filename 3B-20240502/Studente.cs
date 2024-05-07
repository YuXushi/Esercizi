using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_20240502
{
    internal class Studente
    {
        public string IdScuola { get; private set; }
        public string Classe { get; private set; }
        public string Cognome { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataNascita { get; private set; }
        public char Genere { get; private set; }
        public double VotoPagella { get; private set; }

        public Studente(string idScuola, string classe, string cognome, string nome, DateTime dataNascita, char genere, double votoPagella)
        {
            IdScuola = idScuola;
            Classe = classe;
            Cognome = cognome;
            Nome = nome;
            DataNascita = dataNascita;
            Genere = genere;
            VotoPagella = votoPagella;
        }

        public override string? ToString()
        {
            // string adulto = (DataNascita.AddYears(18) <= DateTime.Now) ? "SI" : "NO";
            return "Scuola: " + IdScuola + " Classe: " + Classe + 
                " Cognome: " + Cognome + " Nome: " + Nome +
                " Data di nascita: " + DataNascita.ToShortDateString() +
                " Genere: " + Genere + " Voto in pagella: " + VotoPagella /* + "Maggiorenne: " + adulto */;
        }

        public bool QuestoMaggioreDi(Studente altrostudente)
        {
            if (this.Nome.CompareTo(altrostudente.Nome) < 0)
                return true;
            else return false;
        }
    }
}
