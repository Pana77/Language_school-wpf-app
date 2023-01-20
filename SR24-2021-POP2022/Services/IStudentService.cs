using SR24_2021_POP2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    interface IStudentService
    {
        void ReadStudent();
        int SaveStudent(Object obj);
        void UpdateStudent(Object obj);
        void DeleteStudent(string email);
    }
}
