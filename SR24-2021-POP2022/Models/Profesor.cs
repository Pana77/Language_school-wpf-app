using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Models
{
    [Serializable]
    public class Profesor
    {

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        private RegistrovaniKorisnik _korisnik;

        public RegistrovaniKorisnik Korisnik
        {
            get { return _korisnik; }
            set { _korisnik = value; }
        }

        public override string ToString()
        {
            return ($"{_korisnik.Ime} {_korisnik.Email}");
        }
    }
}