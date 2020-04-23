using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using TemaPIU1;
namespace Formul
{
    class Program
    {
        
        static void Main(string[] args)
        {
            FormularUtilizator form1 = new FormularUtilizator();
            form1.Show();
            Application.Run();
        }
    }
    public class FormularUtilizator : Form
    {
        private Button btnInfo;
        private Label LNume, LPrenume, LBuget, LInfo;
        private TextBox TNume, TPrenume, TBuget;
        private const int LATIME_CONTROL = 150;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 170;
        private const int LUNGIME_MAX = 15;
        public FormularUtilizator()
        {
            this.Size = new System.Drawing.Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(100, 100);
            this.Font = new Font("Tahoma", 9, FontStyle.Italic);
            this.ForeColor = Color.White;
            this.Text = "Formular utilizator";

            LNume = new Label();
            LNume.Width = LATIME_CONTROL;
            LNume.Text = "Nume ";
            LNume.BackColor = Color.Black;
            this.Controls.Add(LNume);

            LPrenume = new Label();
            LPrenume.Width = LATIME_CONTROL;
            LPrenume.Text = "Prenume ";
            LPrenume.BackColor = Color.Black;
            LPrenume.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(LPrenume);

            LBuget = new Label();
            LBuget.Width = LATIME_CONTROL;
            LBuget.Text = "Buget ";
            LBuget.BackColor = Color.Black;
            LBuget.Top = DIMENSIUNE_PAS_Y * 2;
            this.Controls.Add(LBuget);

            TNume = new TextBox();
            TNume.Width = LATIME_CONTROL;
            TNume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 0);
            this.Controls.Add(TNume);

            TPrenume = new TextBox();
            TPrenume.Width = LATIME_CONTROL;
            TPrenume.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y);
            this.Controls.Add(TPrenume);

            TBuget = new TextBox();
            TBuget.Width = LATIME_CONTROL;
            TBuget.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, 2 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(TBuget);

            btnInfo = new Button();
            btnInfo.Width = LATIME_CONTROL;
            btnInfo.Location = new System.Drawing.Point(DIMENSIUNE_PAS_X, DIMENSIUNE_PAS_Y * 4);
            btnInfo.Text = "Adauga Utilizator";
            this.Controls.Add(btnInfo);

            btnInfo.Click += OnClick;

            LInfo = new Label();
            LInfo.Height = 2 * DIMENSIUNE_PAS_Y;
            LInfo.Width = LATIME_CONTROL * 3;
            LInfo.Text = "";
            LInfo.Location = new System.Drawing.Point(0, 5 * DIMENSIUNE_PAS_Y);
            this.Controls.Add(LInfo);
        }
        private void OnClick(object sender, EventArgs e)
        {
            int validare = Validare();
            if (validare == 0)
            {
                Utilizator u = new Utilizator(TNume.Text, TPrenume.Text, Convert.ToInt32(TBuget.Text));
                IStocareData adminUser = StocareFactory.GetAdministratorStocare();
                adminUser.AddUtilizator(u);
                LInfo.Text = u.ConversieLaSir();
            }
            else
            {
                switch (validare)
                {
                    case 1:
                        LNume.ForeColor = Color.Red;
                        break;
                    case 2:
                        LPrenume.ForeColor = Color.Red;
                        break;
                    case 3:
                        LBuget.ForeColor = Color.Red;
                        break;
                    default:
                        break;
                }
            }
        }
        private int Validare()
        {
            if (TNume.Text == string.Empty || TNume.Text.Length > LUNGIME_MAX)
            {
                return 1;
            }
            else if (TPrenume.Text == string.Empty || TPrenume.Text.Length > LUNGIME_MAX)
            {
                return 2;
            }
            else if (TBuget.Text == string.Empty)
            {
                return 3;
            }
            return 0;
        }
    }
}
