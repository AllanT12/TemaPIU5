using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TemaPIU1
{
    public class AdministrareStudenti_FisierText : IStocareData
    {
        private const int PAS_ALOCARE = 10;
        string NumeFisier { get; set; } = "user.txt";
        public AdministrareStudenti_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open("user.txt", FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AddUtilizator(Utilizator u)
        {
                using (StreamWriter swFisierText = new StreamWriter("user.txt", true))
                {
                    swFisierText.WriteLine(u.ConversieLaSir_PentruFisier());
                }
            
           
        }
        public void UpdateUtilizator(Utilizator[] u,int nr)
        {
            var encoding = Encoding.UTF8;
            using (var stream = new FileStream("user.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {

                stream.Position =0;
                using (var writer = new StreamWriter(stream, encoding))
                {
                    for(int z=0;z<=nr;z++)
                    writer.Write(u[z].ConversieLaSir_PentruFisier());
                }
                    
            }
        }
        public Utilizator[] GetUtilizator(out int nrUtilizator)
        {
            Utilizator[] utilizator = new Utilizator[PAS_ALOCARE];

           
           
                using (StreamReader sr = new StreamReader("user.txt"))
                {
                    string line;
                    nrUtilizator = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                    string[] cuv = line.Split(' ');
                        utilizator[nrUtilizator++] = new Utilizator(Convert.ToString(cuv[0]), Convert.ToString(cuv[1]), Convert.ToInt32(cuv[2]));
                        if (nrUtilizator == PAS_ALOCARE)
                        {
                            Array.Resize(ref utilizator, nrUtilizator + PAS_ALOCARE);
                        }
                    }
                }
            

            return utilizator;
        }
    }
}
