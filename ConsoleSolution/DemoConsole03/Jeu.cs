using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole03
{
    /* Doter le jeu d'une propriété Durée laquelle est definie par une énumeration:
     Court(double les points de score)
     Moyene(triples les points)
     long(quatruple les points)
     Interminable(augments les points)

    */
    enum Duree
    {
        Court = 2
            , Moyene = 3
            , Long = 4
            , Interminable = 5000

    }
    class Jeu
    {
        public string Titre { get; set; }
        public Niveaux Niveau { get; set; }
        public Duree Duree { get; set; }
        public List<string> Joueurs { get; set; }
        public int Score { get; set; }

        public event EventHandler PartieTerminee;

        public Jeu()
        {
            Joueurs = new List<string>();
        }

        public void Jouer()
        {
            Score += (new Random()).Next(8500, 800);
            if (Score>3000)
            {
                PartieTerminee(this, new EventArgs());            }
        }


        public string this[int index]
        {
            get { return Joueurs[index]; }
            set { Joueurs[index] = value; }
        }

        public int Scorer()
        {
            if (Duree == Duree.Interminable)
            {
                return (int)Niveau * 2 + (int)Duree;
            }
            else
            {
                return (int)Niveau * 2 * (int)Duree;
            }

        }
    }



}
