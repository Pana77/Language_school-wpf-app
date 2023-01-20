using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    interface ISkolaService
    {
        void ReadSkola();
        int SaveSkola(Object obj);
        void UpdateSkola(Object obj);
        void DeleteSkola(string id);

    }
}
