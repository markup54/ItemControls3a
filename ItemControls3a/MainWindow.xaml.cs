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

namespace ItemControls3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Produkt> ListaProduktow { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            ListaProduktow = new List<Produkt>();
            ListaProduktow.Add(new Produkt("farbki", 12, true));
            ListaProduktow.Add(new Produkt("kredki", 20, true));
            ListaProduktow.Add(new Produkt("blok", 5, true));
     
            ListaProduktow.Add(new Produkt("ołowekB5", 2, true));
            ListaProduktow.Add(new Produkt("ołowekB4", 2, true));
            ListaProduktow.Add(new Produkt("ołowekB3", 2, true));
            ListaProduktow.Add(new Produkt("ołowekB2", 2, true));
            ListaProduktow.Add(new Produkt("ołowekB", 2, true));
            ListaProduktow.Add(new Produkt("ołowekHB", 2, true));
            ListaProduktow.Add(new Produkt("ołowekHB", 1, true));
            ListaProduktow.Add(new Produkt("ołowekHB", 1, true));
            ListaProduktow.Add(new Produkt("ołowekH", 2, true));
           
        }
    }
}
