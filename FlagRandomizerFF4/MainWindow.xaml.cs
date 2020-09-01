using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
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

        private RandomizerMethods randMethods = new RandomizerMethods();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            var combo = sender as ComboBox;
            combo.ItemsSource = FlagsPreset.DicoNomFlag.Values;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedComboItem = sender as ComboBox;
            string name = selectedComboItem.SelectedItem as string;
        }

        private void ChoosePreset_Click(object sender, RoutedEventArgs e)
        {
            var index = BoiteCombo.SelectedIndex;

            if (index != -1)
            {
                NomFlag.Content = FlagsPreset.DicoNomFlag[index];
                ImageFlag.Source = new BitmapImage(new Uri(Sprites.DicoSpriteSeed[index], UriKind.Relative));
                randMethods.ChoixFlag(index);
            }
        }

        private void FromScratch_Click(object sender, RoutedEventArgs e)
        {
            NomFlag.Content = "THE TIME HAS COME !";
            ImageFlag.Source = new BitmapImage(new Uri(Sprites.DicoSpriteSeed[11], UriKind.Relative));
            randMethods.ScratchFlag();
        }

        private void RandomPreset_Click(object sender, RoutedEventArgs e)
        {
            var numero = randMethods.PresetFlag();

            ImageFlag.Source = new BitmapImage(new Uri(Sprites.DicoSpriteSeed[numero], UriKind.Relative));
            NomFlag.Content = FlagsPreset.DicoNomFlag[numero];
        }

        private void OpenTracker_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("En cours de développement !");
            //Process.Start("");
        }
    }
}
