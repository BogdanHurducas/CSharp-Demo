using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoForms03
{
    public partial class buton01 : Form
    {
        public buton01()
        {
            InitializeComponent();
        }

        private void Fermeture(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("bye-bye");
        }

        private void Saisie(object sender, KeyEventArgs e)
        {

        }

       
        private void textNom(object sender, KeyEventArgs e)
        {

        }
    } 
}
