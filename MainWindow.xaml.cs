using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace WpfApp10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StreamWriter sw = new StreamWriter("test.txt");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {

            using (StreamWriter sw = new StreamWriter("../../../test.csv", true))
            {
                if (txtNev.Text.Length>0&&0>DateTime.Compare(DateTime.Now, DateTime.Parse(dpDatum.Text)))
                {
                    MessageBox.Show("Nem megfelelő beviteli értékek");
                }
                else
                {
                    sw.WriteLine($"{txtNev.Text};{cboTargy.Text};{dpDatum.Text};{lblJegy.Content}");
                    MessageBox.Show("Ügyi vagy! :(");
                }
                
            }
        }

        private void sliJegy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblJegy.Content = sliJegy.Value;
        }
    }
}
