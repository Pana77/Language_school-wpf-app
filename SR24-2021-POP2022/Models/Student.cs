using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Models
{
    [Serializable]
    public class Student
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
        private string _casovi;

        public string Casovi
        {
            get { return _casovi; }
            set { _casovi = value; }
        }

        private ObservableCollection<Casovi> _listaCasova;

        public ObservableCollection<Casovi> ListaCasova
        {
            get { return _listaCasova; }
            set { _listaCasova = value; }
        }

        private bool _aktivan;

        public bool Aktivan
        {
            get { return _aktivan; }
            set { _aktivan = value; }
        }

        public override string ToString()
        {
            return "Ja sam student i moje ime je:" + _korisnik.Ime + ", a moj email je :" + _korisnik.Email;
        }

        public string StudentZaUpisUFajl()
        {
            return Korisnik.Email;
        }
    }
}