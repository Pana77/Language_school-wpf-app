using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SR24_2021_POP2022.Models
{
    class Administrator : RegistrovaniKorisnik
    {  
        public string AdminZaUpisFajl()
        {
            return Ime + ";" + Prezime + ";" + JMBG + ";" +
                Email + ";" + Lozinka + ";" + Pol + ";" + TipKorisnika + ";" + Aktivan;
        }
    }
}
