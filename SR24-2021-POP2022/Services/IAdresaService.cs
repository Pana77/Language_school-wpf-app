using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    interface IAdresaService
    {
        void ReadAdresa();
        int SaveAdresa(Object obj);
        void UpdateAdresa(Object obj);
        void DeleteAdresa(int id);

    }
}
