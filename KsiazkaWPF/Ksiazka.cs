using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaWPF
{
    internal class Ksiazka
    {
        public List<Strona> strony = new List<Strona>();

        public Ksiazka(string tytul)
        {
            var strona = new Strona(tytul, 1);
            strony.Add(strona);
        }

        public void DodajStrone(string trescStrony)
        {
            var strona = new Strona(trescStrony);
            strony.Add(strona);
        }
    }
}
