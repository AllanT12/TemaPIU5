using System;
using System.Configuration;

namespace TemaPIU1
{ 
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
                        return new AdministrareStudenti_FisierText(numeFisier + "." + formatSalvare);
        }
    }
}
