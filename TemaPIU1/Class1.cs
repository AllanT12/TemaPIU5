using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    public class Sejur
    {
        string Tara;
        string Oras;
        int pret;
       
        public Climat Climat
        {
            set;
            get;
        }
        public Dotari Dotari
        {
            get;
            set;
        }
      
        public Sejur(string _Tara, string _Oras, string _pret)
        {
            Tara = _Tara;
            Oras = _Oras;
            pret = Convert.ToInt32(_pret);
        }

        public Sejur(string _Tara,string _Oras,int _pret)
        {
            Tara = _Tara;
            Oras = _Oras;
            pret = _pret;
        }

        public Sejur(string rand)
        {
            string[] cuvinte = rand.Split(' ');
            Tara=cuvinte[0];
            Oras = cuvinte[1];
            pret =Convert.ToInt32(cuvinte[2]);
        }

        public string Afisare()
        {
            return string.Format("{0} {1} la pretul de {2} euro",Tara,Oras,pret);
        }
    }
}