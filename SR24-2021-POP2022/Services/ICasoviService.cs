using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    interface  ICasoviService
    {
        void ReadCasovi();
        int SaveCasovi(Object obj);
        void UpdateCasovi(Object obj);
        void DeleteCasovi(int id);
    }
}
