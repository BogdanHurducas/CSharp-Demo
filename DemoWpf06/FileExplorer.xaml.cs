using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using c=System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using f=System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Label = System.Windows.Controls.Label;

namespace DemoWpf06
{
    /// <summary>
    /// Logique d'interaction pour FileExplorer.xaml
    /// </summary>
    public partial class FileExplorer : Window
    {
        private object stkFichiers;

        public FileExplorer()
        {
            InitializeComponent();
        }

        private void BtnParcourir_Click(object sender, RoutedEventArgs e)
        {
            f.FolderBrowserDialog fbdChemin = new f.FolderBrowserDialog();

            if (fbdChemin.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtChemin.Text = fbdChemin.SelectedPath;
                DirectoryInfo diDossier = new DirectoryInfo(fbdChemin.SelectedPath);

                foreach (FileInfo item in diDossier.GetFiles())
                {
                    c.Label lblItem = new c.Label() { Content = item.Name, Width = 120 };
                    lblItem.MouseDoubleClick += LblItem_MouseDoubleClick;
                    stkFichier.Children.Add(lblItem);
                }

            }

        }

        private void LblItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string strNomFichier = ((c.Label)sender).Content.ToString();
            string strChemin = txtChemin.Text + "\\" + strNomFichier;
            FileInfo fichier = new FileInfo(strChemin);
            txtChemin.Text = fichier.Length.ToString();

            foreach (c.Label item in stkFichier.Children)
            {
                item.Background = Brushes.LightGray;
            }
                ((c.Label)sender).Background = Brushes.OrangeRed;
        }


    }

}
