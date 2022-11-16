using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class MyDictionary
    {
        public void Add()
        {
            Dictionary<int,string> uyeler = new Dictionary <int,string>();

            uyeler.Add(0, "Harun");
            uyeler.Add(1, "Halil");
            uyeler.Add(2, "Mehtap");
            uyeler.Add(3, "Rabia");

            foreach (var uye in uyeler)
            {
                Console.WriteLine(uye);
            }
        }
    }
}
