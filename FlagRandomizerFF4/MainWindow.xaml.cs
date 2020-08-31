using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace FlagRandomizerFF4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }

        private void Randomize_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GoSite_Click(object sender, RoutedEventArgs e)
        {
            //Il faut récup l'item de la combobox pour le Preset
            Clipboard.SetText("clipboard");
            Process.Start("http://ff4fe.com/make");
        }
    }
}
