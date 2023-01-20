using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Models
{
    public class Jezik
    {
        private int _id;

        public int Id
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

        public bool _aktivan;

        public bool Aktivan
        {
            get { return _aktivan; }
            set { _aktivan = value; }
        }

        public override string ToString()
        {
            return String.Format("{0}", Naziv);
        }
    }   
        
}
