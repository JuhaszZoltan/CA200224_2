using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200224_2
{
    class Chi
    {
        public string Nev { get; set; }
        public DateTime Szul { get; set; }
        public int Suly { get; set; }
        public bool Simi { get; set; }
        public int Kor => DateTime.Now.Year - Szul.Year;
        public Chi(string s)
        {
            var t = s.Split(';');
            Nev = t[0];
            Szul = DateTime.Parse(t[1]);
            Suly = int.Parse(t[2]);
            Simi = t[3] == "I";
        }
    }
}
