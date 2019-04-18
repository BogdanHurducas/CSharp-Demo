using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole03
{
   
    enum Niveaux
    {
        TresFacile=4
            ,Facile=18
            ,Moyen=154
            ,Difficile=827
            ,TresDificile=3000
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TestEnumeration();
            //TestOuvertureFichierAvecEnum();
            TestIndexeur();

        }

        private static void TestIndexeur()
        {

            Jeu jDame = new Jeu { Titre = "Jeu de dames", Duree = Duree.Court, Niveau = Niveaux.Moyen };
            jDame.Joueurs.Add("Bogdan");
            jDame.Joueurs.Add("Naufel");

            //Récupération d'un nom de joueurs en considérant la variable jDames commes un tableau indexé

            Console.WriteLine(jDame[1]);


            //tentative de jeu
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("tentative en cours n°:", +(i + 1),jDame.Score);
                Console.ReadLine();

            }

        }
	}
}


    
