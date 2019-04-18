using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole05
{
    class Thermos
    {
        public int DureeFraicheurGarantie { get; set; }
        public int Contenance { get; set; }
        //constructeur
        public Thermos(DateTime dateSortie)

        {
            
            {
                DureeFraicheurGarantie = (dateSortie.Month > 4 && dateSortie.Month < 10) ? 4 : 2;

            }

        }

    }
    //class miniThermos :Thermos
    //{

    //    //public miniThermos()
    //    //{
    //    //    Contenance = 200;
    //    //}
       
            
    //}

    


    
}
