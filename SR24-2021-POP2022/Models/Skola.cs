using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Models
{
    [Serializable]
    public class Skola
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _naziv;

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        private string _adresa;

        public string Adresa
        {
            get { return _adresa; }
            set { _adresa = value; }
        }

        private string _jezik;

        public string Jezik
        {
            get { return _jezik; }
            set { _jezik = value; }
        }

        private bool _aktivan;

        public bool Aktivan
        {
            get { return _aktivan; }
            set { _aktivan = value; }
        }

        public override string ToString()
        {
            return "Id" + ID + "Sifra" + Naziv  + "Adresa" + Adresa + "Jezik" + Jezik + "Aktivan" + Aktivan;
        }
    }
}
