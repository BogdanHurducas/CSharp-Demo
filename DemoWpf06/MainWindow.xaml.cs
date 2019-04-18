using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoWpf06
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private string Choix_Ouverture()
        {
            string chemin;

            OpenFileDialog ofdChemin = new OpenFileDialog();
            ofdChemin.ShowDialog();
            if (ofdChemin.FileName != "")
            {
                return ofdChemin.FileName.ToString();
            }
            else
            {
                return "";
            }
        }

        private string Choix_Sauvegarde()
        {
            string chemin;

            SaveFileDialog sfdChemin = new SaveFileDialog();
            sfdChemin.ShowDialog();
            if (sfdChemin.FileName != "")
            {
                return sfdChemin.FileName.ToString();
            }
            else
            {
                return "";
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string chemin = Choix_Sauvegarde();

                if (chemin != "")
                {
                    StreamWriter stmFichier = File.CreateText(chemin);
                    stmFichier.Write(textSaisie.Text);
                    stmFichier.Flush();
                    stmFichier.Close();
                    System.Windows.MessageBox.Show("Enregistrement réussi!");
                }
                
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Enregistrement echoué!");
            }
        }

        private void btnOuvrir_Click(object sender, RoutedEventArgs e)
        {
            string strChemin = Choix_Ouverture();
            if (strChemin != "")
            {
                textSaisie.Text = File.ReadAllText(strChemin);
            }
        }

    }
}


