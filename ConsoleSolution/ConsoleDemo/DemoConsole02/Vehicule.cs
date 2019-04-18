using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole02
{
    class Vehicule
    {

        public string Culeur;

        private int cylandree;

        public int Cylandree
        {
            get { return cylandree; }
            set {
                if(value>100 && value<8000)
                {   
                    cylandree = value;
                }
                else
                {
                    throw new Exception("cilebdree nebon");

                }
        }

    }
}
