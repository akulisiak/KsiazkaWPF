using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KsiazkaWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;
        public MainWindow()
        {
            InitializeComponent();
            tylButton.Content = "<<<";
            przodButton.Content = ">>>";

           
        }

        private void przodButton_Click(object sender, RoutedEventArgs e)
        {
            string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\dane.txt");
            string[] tablicaStron = daneZPliku.Split(';');

            Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

            for (int i = 1; i < tablicaStron.Length; i++)
            {
                ksiazka.DodajStrone(tablicaStron[i]);
            }

            tytulLabel.Content = "Tytuł książki: " + ksiazka.strony[0].trescStrony;

            lewaTextBlock.Text = ksiazka.strony[i].trescStrony;
            prawaTextBlock.Text = ksiazka.strony[i + 1].trescStrony;
            i += 2;
        }

        private void tylButton_Click(object sender, RoutedEventArgs e)
        {
            i -= 2;
            string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\dane.txt");
            string[] tablicaStron = daneZPliku.Split(';');

            Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

            for (int i = 1; i < tablicaStron.Length; i++)
            {
                ksiazka.DodajStrone(tablicaStron[i]);
            }

            tytulLabel.Content = "Tytuł książki: " + ksiazka.strony[0].trescStrony;

            lewaTextBlock.Text = ksiazka.strony[i].trescStrony;
            prawaTextBlock.Text = ksiazka.strony[i + 1].trescStrony;
            
        }

        private void HandleChange(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}