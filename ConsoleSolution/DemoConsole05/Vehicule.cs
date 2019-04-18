using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    class Vehicule : IVehicule
    {
        public virtual void Frainer()
        {
            Console.WriteLine("Le VEHICULE fraine");
        }

        public void Rouler()
        {
            Console.WriteLine("Le VEHICULE roule");
        }
    }

    class Voiture : Vehicule
    {
        public override void Frainer()
        {
            Console.WriteLine("le veh frainnnnnnnnnnnnnnnn");
        }

        public void Klaxoner()

        {

        Console.WriteLine(" la voiture fait tou tou");
        }
    }
}
