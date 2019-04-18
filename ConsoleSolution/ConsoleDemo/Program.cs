using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{


    class Program
    {
        //Plan : Classe

        //Maison : Objet, Instance


        static void Main(string[] args)
        {

            #region Demo1 Variables

            ////Une chaîne nommée strMessage qui vaut 'Youpi'
            //string strMessage = "Youpi";

            ////Une date nommée dateCourante qui vaut la date du jour (demander à DateTime)
            //DateTime dateCourante = DateTime.Today;

            ////Un entier long nommé lngSomme qui vaut 250 000
            //long lngSomme = 250000;

            ////Un nouvel objet StringBuilder nommé sbChaine
            //StringBuilder sbChaine = new StringBuilder();

            ////Variable sans type :
            ////Z = 10; //erreur
            //var Y = 10;

            ////Déclaration sans initialisation
            //int b;

            ////Initialisation d'une variable double dblTTC par une expression exmploitant
            ////la variable dblHT
            //double dblHT = 100;
            //double dblTTC = dblHT * 1.2;
            ////Initialisation d'une variable booléenne par une expression de comparainson sur dblTTC
            //bool boolComparaison = dblTTC > 200; 
            #endregion

            #region Demo2 Utilisation Objets
            ////Données

            //string strNomDossier; //contient le nom du répertoire à créer sur C
            //string strNomFichier; //contient le nom du fichier texte à créer dans le dossier précédent
            //string strMessage; //contient le texte à insérer dans le fichier texte précédent
            //DirectoryInfo dirDossier;
            //StreamWriter streamFichier;

            ////Saisie des 3 informations
            //Console.WriteLine("Merci de'indiquer le nom du dossier :");
            //strNomDossier = Console.ReadLine();
            //Console.WriteLine("Merci de'indiquer le nom du fichier :");
            //strNomFichier = Console.ReadLine();
            //Console.WriteLine("Merci de'indiquer votre texte :");
            //strMessage = Console.ReadLine();

            ////Création du dossier
            //dirDossier = Directory.CreateDirectory(@"c:\" + strNomDossier);

            ////Création du fichier
            //streamFichier = File.CreateText(dirDossier.FullName + "\\" + strNomFichier);

            ////Ecriture au sein du fichier
            //streamFichier.WriteLine(strMessage);
            //streamFichier.Flush();
            //streamFichier.Close();

            ////Confirmation
            //Console.WriteLine("Le fichier {0} a été créé dans le dossier {1} !!!!"
            //    , strNomFichier
            //    , dirDossier.FullName
            //    );


            #endregion

            #region Demo3 Conversions d'entiers
            ////Données
            //int intNbCarateres;
            //string strMessage;

            ////Corps
            ////Récupérer le nombre de lettres composant un message
            //Console.Write("saisir un message");
            //strMessage = Console.ReadLine();
            //intNbCarateres = (int)strMessage.LongCount();



            #endregion

            #region Demo4 Conversions chaînes vers entier
            //string strChaineAConvertir;
            //int intValeurCible;
            //bool reussite;

            ////Saisie d'une chaine contenant peut-être une valeur convertible en entier
            //Console.Write("Saisir des chiffres, s.v.p. :");
            //strChaineAConvertir = Console.ReadLine();

            ////Tentative de conversion
            //reussite=int.TryParse(strChaineAConvertir, out intValeurCible);

            ////Vérification
            //Console.WriteLine("La conversion de {0} a réussi : {2} : {1}"
            //    ,strChaineAConvertir
            //    ,intValeurCible
            //    ,reussite
            //    );



            #endregion

            #region Demo5 Utilisation de IF


            //string strSaisie;
            //            int intAge;
            //            decimal dTarif=100;
            //            string strMessage;


            //            //Saisie de l'age
            //            Console.Write("Saisir votre age : ");
            //            strSaisie = Console.ReadLine();

            //            //Vérification de la validité de l'age
            //            if (!int.TryParse(strSaisie,out intAge))
            //            {
            //                strMessage = "Mauvaises saisies";
            //            }
            //            else if (intAge<20)
            //            {
            //                strMessage = "Moins de 20 ans";
            //                dTarif = 50;
            //            }
            //            else if (intAge<60)
            //            {
            //                strMessage = "Actifs";
            //                dTarif = 95;
            //            }
            //            else
            //            {
            //                strMessage = "Retraités";
            //                dTarif = 60;
            //            }

            //            //Message final
            //            Console.WriteLine("Tarif : {0} - pour les {1}",dTarif,strMessage);

            #endregion

            #region Exercice01 IF
            //Demander à l'utilisateur de se choisir un pseudo
            /*
             Pour valider un pseudo, il faut que:
             Le pseudo contienne au moins 5 caractères, sinon il sera invalidé
             Le pseudo ne contient pas de Z ni de K, sinon il sera transformé en remplaçant les
             Z ou z par des S ou s, les K ou k par des Q ou q

            Une fois les tests de validation et les éventuelles transformations réalisées, afficher
            un message indiquant s'il est validé ou non et affichant le pseudo.

             */
            //string strPseudo;
            //string strMessage;

            ////Saisie du pseudo
            //Console.WriteLine("Saisir un pseudo :");
            //strPseudo = Console.ReadLine();

            ////Test de longueur et traitement des Z et K

            //if (strPseudo.Length<5)
            //{
            //    strMessage = "Invalidé par manque de caractères";
            //}
            //else
            //{
            //    strPseudo = strPseudo.Replace("Z", "S").Replace("z", "s").Replace("k", "q").Replace("K", "Q");
            //    //strMessage = "Pseudo validé : " + strPseudo;
            //    strMessage = string.Format("Pseudo validé : {0} !!!", strPseudo);
            //}

            //Console.WriteLine(strMessage);
            //Console.Read();



            #endregion

            #region Demo6 Utilisation de switch

            ////Construction d'un menu

            //string strChoix;

            //string strMessage;

            ////Invite
            //Console.WriteLine("Votre choix?");
            ////Saut de ligne
            //Console.WriteLine();
            ////Propositions
            //Console.WriteLine("1......Partager");
            //Console.WriteLine("2......Imprimer");
            //Console.WriteLine("3......Modifier");
            //Console.WriteLine("4......Supprimer");

            ////Récupération du choix
            //strChoix = Console.ReadLine();

            //switch (strChoix)
            //{
            //    case "1":
            //        strMessage = "Votre document va être envoyé";
            //        break;
            //    case "2":
            //        strMessage = "Votre doument est en cours d'impression";
            //        break;
            //    case "3":
            //        strMessage = "Modification en cours";
            //        break;
            //    case "4":
            //        strMessage = "Suppression à confirmer";
            //        break;
            //   default:
            //        strMessage = "Nous n'avons pas compris votre choix";
            //        break;
            //}

            //Console.WriteLine(strMessage);

            #endregion

            #region Demo7 Boucle For

            ////Afficher les températures Celsius converties en Fahrenheit de 0 à 100 dégrés Celsius par pas de 10

            //for (int i = 0; i <= 100; i+=10)
            //{
            //    Console.WriteLine("Pour {0}°c....{1}°f" ,i,i*9/5+32);
            //}

            #endregion

            #region Exercice02 For

            //verlan
            /*à l'aide d'une boucle for
             inverser toutes les caractères d'une phrase saisie par 
             l'utilisateur
             */

            //string strChaine;
            //string strChaineMiroir="";

            ////Saisie
            //Console.WriteLine("Saisir un texte");
            //strChaine = Console.ReadLine();

            ////Inversion
            //for (int i = strChaine.Length-1; i >=0; i--)
            //{
            //    strChaineMiroir = strChaineMiroir + strChaine.ElementAt(i).ToString();
            //}



            //Console.WriteLine(strChaineMiroir);
            //Console.ReadLine();



            #endregion

            #region Demo8 Boucle ForEach

            ////Parcours de fichiers
            //DirectoryInfo dirDossier = new DirectoryInfo(@"c:\windows");

            //foreach (FileInfo fichier in dirDossier.GetFiles())
            //{
            //    Console.WriteLine("{0}.....{1}", fichier.Name, fichier.Length);
            //}

            #endregion

            #region Exercice03 ForEach

            /*
             En utilisant une boucle ForEach, chacun des fichiers
             de plus de 50000 octets issus de c:\windows
             devra être affiché à l'écran
             */
            //DirectoryInfo dirDossier = new DirectoryInfo(@"c:\windows");

            //foreach (FileInfo fichier in dirDossier.GetFiles())
            //{
            //    if (fichier.Length>50000)
            //    {
            //        Console.WriteLine("{0}......{1:N2}Kb"
            //            ,fichier.Name
            //            ,fichier.Length/1024D
            //            );
            //    }
            //}

            #endregion

            #region Demo9 Do Loop
            //Calculer un TTC depuis un HT saisi par l'utilisateur

            //decimal dMontantHT;
            //decimal dMontantTTC;

            ////Saisie potentiellement répétable si non convertible en décimal

            //do
            //{
            //    Console.WriteLine("Saisir un montant H.T. : ");
            //} while (!decimal.TryParse(Console.ReadLine(),out dMontantHT));

            //dMontantTTC = dMontantHT * 1.2M;

            //Console.WriteLine("Le TTC pour un HT de {0} est {1}"
            //    ,dMontantHT
            //    ,dMontantTTC
            //    );

            #endregion

            #region Exercice04 Do While

            /*
             L'utilisateur est appelé à saisir une date de réunion
             La date sera validée et confirmée à l'écran si elle correspond
             à un jour de semaine et non un samedi ou un dimanche
             */

            //DateTime dateSaisie=DateTime.Today;

            //do
            //{
            //    Console.WriteLine("Saisir une date ('yy/mm/dd')");
            //} while (
            //!DateTime.TryParse(Console.ReadLine(),out dateSaisie)
            //|| dateSaisie.DayOfWeek==DayOfWeek.Saturday 
            //|| dateSaisie.DayOfWeek == DayOfWeek.Sunday
            //);

            //Console.WriteLine("Ok confirmé pour le {0:dddd MMM yyyy}"
            //    ,dateSaisie
            //    );



            #endregion

            #region Demo10 Tableaux

            //   //Déclaration d'une variable tableau
            //   //Tableau de chaines
            //   string[] prenoms = {
            //       "Sofiene"
            //           , "Fayçal"
            //           , "Bogdan"
            //           , "Naoufel"
            //           , "Renaud"
            //           , "Marco"
            //           , "Annette"
            //           , "Marc-Antoine"
            //   };
            ////Aucune chaine n'est encore allouée 

            //   //Allocation de la chaine correspondant au 7eme prénom
            //   prenoms[6] = "Adib";


            //   //Allocation de la chaine correspondant au 12eme prénom
            //   prenoms[2] = "Salam";

            //   //Parcours de tout le tableau
            //   for (int i = 0; i < prenoms.Length; i++)
            //   {
            //       Console.WriteLine(prenoms[i]);
            //   }


            #endregion

            #region Demo11 Expression ternaire

            int a = 15;
            string strMessage;
            StringBuilder sb;

            //Condition par if
            if (a>0)
            {
                strMessage = "A est positif";
            }
            else
            {
                strMessage = "A est négatif";
            }

            //Expression ternaire

            strMessage = (a > 0) ? "A est positif" : "A est négatif";


            #endregion



        }
    }    

}
