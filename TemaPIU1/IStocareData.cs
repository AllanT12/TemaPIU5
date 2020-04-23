using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
   public interface IStocareData
    {
        void AddUtilizator(Utilizator u);
        Utilizator[] GetUtilizator(out int nrUtilizatori);
        void UpdateUtilizator(Utilizator[] u,int nr);
    }
}
