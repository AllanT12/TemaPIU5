using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaPIU1
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilizator[] utilizators;
            IStocareData adminUser= StocareFactory.GetAdministratorStocare();
            int nrUtilizatori;
            utilizators = adminUser.GetUtilizator(out nrUtilizatori);
            Utilizator.IdUltimUtilizator = nrUtilizatori;
            Random rnd = new Random();
            int i = rnd.Next(1, 4);//1->3
            Sejur T1 = new Sejur("Romania", "Bucurest", 500);
            T1.Climat =(Climat)1;//lab5
            T1.Dotari = (Dotari)3;//lab 5
            Console.WriteLine(Convert.ToString(T1.Dotari));
            Sejur T2 = new Sejur("Italia", "Roma", 1000);
            T2.Climat = (Climat)1;//lab 5
            Sejur T3 = new Sejur("Spania", "Madrid", 1500);
            T3.Climat = (Climat)3;//lab 5
            //nou
            AfisareUtilizatori(utilizators, nrUtilizatori);
            Utilizator U = new Utilizator("Tanasa", "Alin", 1000);
            utilizators[nrUtilizatori] = U;
            nrUtilizatori++;
            Console.WriteLine("Felicitari!");
            Console.WriteLine(U.Nume);
            Console.WriteLine("Ati castigat un sejur la:");
            if (i == 1)
            { string s1 = T1.Afisare(); Console.WriteLine(s1); }
            else if(i==2)
            { string s1 = T2.Afisare(); Console.WriteLine(s1); }
            else
            { string s1 = T3.Afisare(); Console.WriteLine(s1); }
            //lab 3 ex 1
            string[] randuri = System.IO.File.ReadAllLines(@"C:\Users\Alin\Desktop\TemaPIU1\TemaPIU1\input.txt");
            foreach(string rand in randuri)
            {
                Sejur T4 = new Sejur(rand);
                //daca punem mai multe randuri ar trebuii sa creeam un vector de de obiecte de tipul Sejur
                string s2 = T4.Afisare(); Console.WriteLine(s2);//in mod normal nu pun afisare aici
            }
            //lab 4 ex 1
            Console.WriteLine("Nume:");
            string nume=Console.ReadLine();
            Console.WriteLine("Prenume:");
            string prenume = Console.ReadLine();
            Console.WriteLine("Buget:");
            int buget =Convert.ToInt32(Console.ReadLine());
            Utilizator U2 = new Utilizator(nume,prenume,buget);
            Console.WriteLine(U.ConversieLaSir());
            Console.WriteLine(U2.ConversieLaSir());
            //adugare in fisier
            utilizators[nrUtilizatori] = U2;
            nrUtilizatori++;
            adminUser.AddUtilizator(U2);
            //lab 4 ex 2
            Console.WriteLine(U.compara(U2));
            //lab 5 ex 1
            Console.WriteLine("Cum vi s-a parut optiune primita?\nMare=1\nMedie=2\nMica=3\n");
            int optiune= Convert.ToInt32(Console.ReadLine());
            U.Distanta = (Distanta)optiune;
            //lab 5 ex 3
            Console.WriteLine("pe cine vreti sa gasiti");
             nume = Console.ReadLine();
            for(int f=0;f<nrUtilizatori;f++)
            {
                if (utilizators[f].Nume == nume)
                {
                    Console.WriteLine("buget nou");
                    int bug =Convert.ToInt32(Console.ReadLine());
                    utilizators[f].Buget = bug;
                    adminUser.UpdateUtilizator(utilizators,f);
                }
            }
            Console.ReadKey();
        }
        public static void AfisareUtilizatori(Utilizator[] utilizators, int Utilizatori)
        {
            for (int i = 0; i < Utilizatori; i++)
            {
                Console.WriteLine(utilizators[i].ConversieLaSir());
            }
        }
    }
}
