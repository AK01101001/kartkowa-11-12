using System.Windows.Media;
using System.Windows.Media.Imaging;
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
    public class Zdjecie
    {
        public ImageSource source { get; }
        public int lWys { get; set; }

        public Zdjecie(string source)
        {
            this.source = new BitmapImage(new Uri(source, UriKind.Relative));
        }
    }
}