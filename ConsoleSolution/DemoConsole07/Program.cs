using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DemoConsole07
{
    class Program
    {
        static void Main(string[] args)
        {

            //test t = new test();


            //Demo AdoNet();
            //DemoEntity();
            // DemoLinq();
            DemoTypesAnonymes();
           
        }

        private static void DemoTypesAnonymes()
        {
            //Initialisation du contexte de données
            NorthContexte contexte = new NorthContexte();

            //Récuperation de certains collones de client parisiens
            var enumerationFiltree = contexte.Customers
                .Where(c => c.City == "Paris")
                .Select(cl => new { cl.CompanyName, cl.City });

            //Parcours et affichage

            foreach (var item in enumerationFiltree)
            {
                Console.WriteLine("{0}      {1}"
                    , item.CompanyName
                    , item.City
                    );
            }
        }

        private static void DemoLinq()
        {
            //Initialisation du contexte

            NorthContexte contexte = new NorthContexte();

            //Récupération des clients parisiens via LINQ
            IEnumerable<Customer> clientsParis = contexte.Customers.Where(c => c.City == "Paris");

            //Parcours et affichage

            foreach (Customer c in clientsParis)
            {
                Console.WriteLine("{0}      {1}"
                    , c.CompanyName
                    , c.City
                    );
            }

        }

        private static void DemoEntity()
        {
            //Initialisation du contexte de données
            NorthContexte contexte = new NorthContexte();

            //Recupération des clients

            IEnumerable<Customer> clients = contexte.Customers;

            //Parcours et affichage

            foreach (Customer c in clients)
            {
                Console.WriteLine("{0}      {1}"
                    ,c.CompanyName
                    ,c.City
                    );
            }
        }

        private static void DemoAdoNet()
        {
            //inisalisation et ouverture de la conection
            SqlConnection cnx = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True");

            cnx.Open();

            //Initialisation et parametrage de la requete(sqlcomand)
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from Categories";

            //creation d'un lecteur de donee conecte
            SqlDataReader lecteur = cmd.ExecuteReader();

            //Parcours des donees du lecteur

            while (lecteur.Read())
            {
                Console.WriteLine("{0}       {1}"
                    , lecteur.GetString(1)
                    , lecteur.GetString(2)
                    );
            }

        }
    }
    }

 