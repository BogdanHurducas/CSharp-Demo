using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    class Program
    {
        static void Main(string[] args)
        {
            //CobsoHeritage();
            //ConsoClasseAbstraite();
            //ExerciceAbstraction();
            //DemoheritagEtconsturucteur();
           // DemoMetodeExtension();
           MetodeExtension2Leretour();
        }

        private static void MetodeExtension2Leretour()
        {
            List<Thermos> lstThermos = new List<Thermos>() {
             new Thermos(DateTime.Today) {Contenance=500}
            ,new Thermos(DateTime.Today) {Contenance=450}
            ,new Thermos(DateTime.Today) {Contenance=520}
            ,new Thermos(DateTime.Today) {Contenance=300}
            ,new Thermos(DateTime.Today) {Contenance=800}
            ,new Thermos(DateTime.Today) {Contenance=1000}
            };

            //Recherche d'une contenence minuimum via extension Linq
            IEnumerable<Thermos> ThermosGrandFormat =
                lstThermos.Where(t => t.Contenance >= 500);
        }

        private static void DemoMetodeExtension()
        {
            double mt = 12.5789;
            Console.WriteLine(mt.VersChaineADeuxDecimales());
        }

        private static void DemoheritagEtconsturucteur()
        {
            //Thermos th1 = new Thermos();
            //miniThermos mth1 = new miniThermos();

            //Console.WriteLine("duree de fraicheur de termos:"+ th1.DureeFraicheurGarantie);
            //Console.WriteLine("duree de fraicheur de mini-termos:" + mth1.DureeFraicheurGarantie);
            //Console.WriteLine("constanace de thermos:"+ th1.Contenance);
        }

        private static void ExerciceAbstraction()
        {
            //Une classe Activite abstraite propose deux metodes concretes
            //.FacturerFraisDosier() qui annonces des frais de 80€
            //.Obtenir lidcence() qui anonce que la licence de comandée

            //mais aussi 2 metodes abstraites
            //.facturer() qui cumulera au frais de dossier une somme arbitraire
            //.InscrireCompetition() qui annoncera la date de la prochaine compet

            //une classe Danse heritera des Activite, coutra 150€ hors frais d'annonces une complet
            //prevue 2 mois plus tard

            //une classe Basket heritera des Activite, coutra 175€ hors frais d'annonces une complet
            //prevue 1 moi plus tard

            //appeler les 4 metodes sur un onjet Danse et un objet Basket 

            List<Activite> lstActivites = new List<Activite>() {
                new Danse(), new Basket()
        };

        foreach (Activite item in lstActivites)
	    {
                item.ObtenirLicense();
                Console.WriteLine("Vous devez regler{0} pour l'activite {1}" 
                    ,item.Facturer()
                    , item.GetType().Name
                    );
                Console.WriteLine("Pour l'activité {0} la prochaine compétition aur lieu le {1}"
                    , item.GetType().Name
                    , item.InscrireCompetition().ToShortDateString()
                    );
            }


        }
     
      

       


        private static void ConsoClasseAbstraite()
        {
            Voyage v = new Treck();
        }

        private static void ConsoTableauHeritage()
        {
            Vehicule veh1 = new Vehicule();
            Voiture voit1 = new Voiture();
            List<Vehicule> lstvehicules = new List<Vehicule>() { veh1, voit1 };
            //faire ropuler toutes les elem de la liste
            foreach (IVehicule item in lstvehicules)
            {
                item.Rouler();
                item.Frainer();

            }
        }


        private static void CobsoHeritage()
        {
            Vehicule veh1 = new Vehicule();
            Voiture voit1 = new Voiture();

            //Faire rouler les 2 vehicules
            veh1.Rouler();
            voit1.Rouler();

            //Klaxon de voiture
            voit1.Klaxoner();

            //frainer des  veh
            veh1.Frainer();
            voit1.Frainer();
            Console.WriteLine();

        }
    }
}
