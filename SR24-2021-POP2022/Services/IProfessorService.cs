using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SR24_2021_POP2022.Models;

namespace SR24_2021_POP2022.Services
{
    interface IProfessorService
    {
        void ReadProfesor();
        void ReadSkola();
        void ReadAdresa();
        int SaveProfesor(Object obj);
        void UpdateProfesor(Object obj);
        void DeleteProfesor(string email);

    }
}
