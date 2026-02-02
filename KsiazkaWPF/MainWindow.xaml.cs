using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace KsiazkaWPF
{
    public partial class MainWindow : Window
    {
        int i = 1; // aktualna lewa strona (0 = tytuł)
        Ksiazka ksiazka;
        int liczbaStron;

        public MainWindow()
        {
            InitializeComponent();

            string daneZPliku = File.ReadAllText(@"C:\Users\Alek\Desktop\dane.txt");
            string[] tablicaStron = daneZPliku.Split(';');

            ksiazka = new Ksiazka(tablicaStron[0]); // tytuł

            for (int j = 1; j < tablicaStron.Length; j++)
            {
                ksiazka.DodajStrone(tablicaStron[j]);
            }

            liczbaStron = ksiazka.strony.Count - 1;

            tytulLabel.Content = "Tytuł książki: " + tablicaStron[0];

            tylButton.Content = "<<<";
            przodButton.Content = ">>>";

            PokazStrony();
        }

        private void HandleChange(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            if (btn == przodButton)
            {
                if (i + 1 < ksiazka.strony.Count)
                    i += 2;
            }
            else if (btn == tylButton)
            {
                if (i - 2 >= 1)
                    i -= 2;
            }

            PokazStrony();
        }

        private void PokazStrony()
        {
            lewaTextBlock.Text = ksiazka.strony[i].trescStrony;

            if (i + 1 < ksiazka.strony.Count)
                prawaTextBlock.Text = ksiazka.strony[i + 1].trescStrony;
            else
                prawaTextBlock.Text = "";

            int lewa = i;
            int prawa = (i + 1 < ksiazka.strony.Count) ? i + 1 : i;

            stronyLabel.Content = $"Strony {lewa},{prawa} / {liczbaStron}";
        }
    }
}
