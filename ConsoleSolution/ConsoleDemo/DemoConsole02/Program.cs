using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
    class Program
    {
        static void Main(string[] args) =>
            //Demo01SaisieEtConversion();



            //Exercice01CreationPseudo();




            NombreDeJoursOuvres("01/2019");

        private static void NombreDeJoursOuvres(string strChoix)
        {

            DateTime dateInitiale;
            DateTime dateCourante;
            int intCompteurJoursOuvres=0;

            //Constituer le 1 du mois
           if( !DateTime.TryParse(strChoix, out dateInitiale))
            {
                throw new Exception("Choix non valide");
            }
            dateCourante = dateInitiale;
            do
            {
                if (dateCourante.DayOfWeek != DayOfWeek.Saturday && dateCourante.DayOfWeek != DayOfWeek.Sunday) 
                {
                    intCompteurJoursOuvres++;
                }
                dateCourante.AddDays(1);
            } while (dateInitiale.Month==dateCourante.Month);

            Console.WriteLine("Nombre de jours ouvres pour{0} :{1}" 
                ,strChoix
                ,intCompteurJoursOuvres);
        }

        
        private static void Exercice01CreationPseudo()
        {

            //Créer une méthode Exercice01CreationPseudo
            //Cette méthode fait saisir un pseudo
            //Le Pseudo sera validé par une méthode ValidationPseudo
            //qui vérifie qu'il y a au moins 8 lettres, s'il en manque,
            //on ajoutera un nombre aléatoire composé d'autant de chiffres
            //qu'il manque de lettres
            //La méthode Exercice01CreationPseudo affichera le Pseudo validé


            string strPseudo;
            Console.WriteLine("Saisir un pseudo");
            strPseudo = Console.ReadLine();

            Console.WriteLine("Votre pseudo validé : {0}"
                , ValidationPseudo(strPseudo)
                );

        }


        private static string ValidationPseudo(string strPseudo)
        {
            if (strPseudo.Length < 8)
            {
                int intLongueurManquante = 8 - strPseudo.Length;
                Random rnd = new Random();
                int intNombreComplement = rnd.Next(0,(int)Math.Pow(10, intLongueurManquante));
                strPseudo += intNombreComplement.ToString("D" + intLongueurManquante);
            }


            return strPseudo;
        }




        private static void Demo01SaisieConversion()
        {
            //Proposer la conversion d'une temperature en Celsius vers du Farenheit

            decimal[] Temperatures = new decimal[4];
            for (int i = 0; i < Temperatures.Length; i++)
            {
                Temperatures[i] = SaisieDecimal("Choisir une temperature");
                Console.WriteLine("{0}°c equivqlent a {1}°f"
                    , Temperatures[i]
                    , CelsiusVersFahrenheit(Temperatures[i]));
            }
        }

        private static decimal SaisieDecimal(string strInvite)
        {
            decimal dSaisie;
            do
            {
                Console.WriteLine(strInvite);
            } while (!decimal.TryParse(
                Console.ReadLine()
                , out dSaisie)
                );
            return dSaisie;
        }

        private static decimal CelsiusVersFahrenheit(decimal dCelsius)
        {
            return dCelsius * 9 / 5 + 32;
        }
    }
}
