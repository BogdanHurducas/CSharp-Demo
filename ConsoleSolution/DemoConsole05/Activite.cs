using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
   public abstract class Activite
    {
        public int FacturerFraisDossier()
        {
            
            return 80;
        }

        public void ObtenirLicense()
        {
            Console.WriteLine("La license a ete comandée pour l'activite {0}",this.GetType().Name
                ); 
            
        }

        public abstract double Facturer();

        public abstract DateTime InscrireCompetition();

    }

    public class Danse : Activite
    {
        public override double Facturer()
        {
          ;
            return FacturerFraisDossier() + 150;
        }

        public override DateTime InscrireCompetition()
        {

            return DateTime.Today.AddMonths(2);
        }



    }
    public class Basket : Activite
    {
        public override double Facturer()
        {
            return FacturerFraisDossier() + 175;
        }

        public override DateTime InscrireCompetition()
        {

            return DateTime.Today.AddMonths(1);
        }
    }
}
