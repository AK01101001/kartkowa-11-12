using System;
using System.Collections;
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

namespace KartkowkaAK15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Zdjecie> zdjecia = new List<Zdjecie>();
        int indexOfLastDisplayed = -1;
        public MainWindow()
        {
            InitializeComponent();
            zdjecia.Add(new Zdjecie("Barania.png"));
            zdjecia.Add(new Zdjecie("Beskid.png"));
            zdjecia.Add(new Zdjecie("Czantoria.png"));
            zdjecia.Add(new Zdjecie("Skrzyczne.png"));
            zdjecia.Add(new Zdjecie("Zar.png"));
        }

        private void Pokaz(object sender, RoutedEventArgs e)
        {
            ComboBox wybor = lista;
            zdjecie.Source = zdjecia[wybor.SelectedIndex].source;
           
            if (indexOfLastDisplayed != wybor.SelectedIndex)
            {
                indexOfLastDisplayed = wybor.SelectedIndex;
                zdjecia[wybor.SelectedIndex].lWys++;
            }
            lWys.Text = zdjecia[wybor.SelectedIndex].lWys.ToString();
        }
    }
}
