using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SR24_2021_POP2022.Models
{
    public class Casovi
    {
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private RegistrovaniKorisnik _profesor;

        public RegistrovaniKorisnik Profesor
        {
            get { return _profesor; }
            set { _profesor = value; }
        }
        private DateTime _datum;

        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        private DateTime _vremePocetka;

        public DateTime VremePocetka //sati i minuta
        {
            get { return _vremePocetka; }
            set { _vremePocetka = value; }
        }
        private string _trajanje;

        public string Trajanje //minuta
        {
            get { return _trajanje; }
            set { _trajanje = value; }
        }
        private RegistrovaniKorisnik _student;

        public RegistrovaniKorisnik Student
        {
            get { return _student; }
            set { _student = value; }
        }

        private ECas _status;

        public ECas Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private bool _aktivan;

        public bool Aktivan
        {
            get { return _aktivan; }
            set { _aktivan = value; }
        }



        public override string ToString()
        {
            return  ($"{Profesor} {Datum} {Pocetak} {Trajanje} {Student} {Status}");
        }
    } 
}
