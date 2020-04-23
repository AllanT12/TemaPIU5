using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    public class Utilizator
    {
        public Distanta Distanta
        {
            get;
            set;
        }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Buget { get; set; }
        public static int IdUltimUtilizator { get; set; } = 0;
        public Utilizator(string _Nume,string _Prenume,int _Buget)
        {
            Nume = _Nume;
            Prenume = _Prenume;
            Buget = _Buget;
        }
        //ex1 lab 4
        public string ConversieLaSir()
        {

            string s=string.Format("Utilizatorul {0} {1} are bugetul {2} Euro",Nume,Prenume,Buget);
            return s;
        }
        //ex2 lab 4
        public string compara(Utilizator utilizator)
        {
            if (Buget < utilizator.Buget)
                return"utilizatorul "+utilizator.Nume+" are mai multi bani";
            else if (Buget == utilizator.Buget)
                return"utilizatorii au acelasi buget";
            else
                return"utilizatorul "+Nume+ " are mai multi bani";
        }
        //Lab 5
        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{0} {1} {2}",Nume,Prenume,Buget);

            return s;
        }
       public void SetBuget(int _buget)
        {
            Buget = _buget;
        }
    }
}
