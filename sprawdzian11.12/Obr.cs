using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprawdzian11._12
{
    public class Obraz
    {
        public int liczbaPolubien { get; set; }
        public string Nazwa { get; set; }

        public Obraz(string urlObrazka)
        {
            Nazwa = urlObrazka;
            liczbaPolubien = 0;
        }
    }


}
