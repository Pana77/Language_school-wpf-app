using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    interface IJezikService
    {
        void ReadJezik();
        int SaveJezik(Object obj);
        void UpdateJezik(Object obj);
        void DeleteJezik(string id);
    }
}
