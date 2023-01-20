using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    interface IUserService
    {
        int SaveUser(Object obj);

        void ReadUsers();

        void DeleteUser(string email);
    }
}
