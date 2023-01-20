using SR24_2021_POP2022.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    class StudentService : IUserService, IStudentService
    {
        public void DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public List<RegistrovaniKorisnik> ListAllStudent()
        {
            throw new NotImplementedException();
        }

        public void ReadUsers()
        {
            Data.Instance.Studenti = new ObservableCollection<Student>();
            Data.Instance.Korisnici = new ObservableCollection<RegistrovaniKorisnik>();

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                DataSet ds = new DataSet();

                string selectedUser = @"select * from Korisnici";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectedUser, conn);
                dataAdapter.Fill(ds, "Korisnici");

                foreach (DataRow dataRow in ds.Tables["Korisnici"].Rows)
                {
                    //od reda u tabeli kreiramo objekat(korisnik)
                    RegistrovaniKorisnik korisnik = new RegistrovaniKorisnik
                    {
                        Ime = dataRow["Ime"].ToString(),
                        Prezime = dataRow["Prezime"].ToString(),
                        JMBG = dataRow["Jmbg"].ToString(),
                        Email = dataRow["Email"].ToString(),
                        Lozinka = dataRow["Lozinka"].ToString(),
                        Aktivan = (bool)dataRow["Aktivan"],
                        TipKorisnika = ETipKorisnika.STUDENT,
                        Pol = EPol.MUSKI
                    };
                    Data.Instance.Korisnici.Add(korisnik);
                }
            }

        }

        public int SaveUser(Object obj)
        {

            Student student = obj as Student;

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"insert into dbo.Studenti(Id)
                output inserted.id values(@Id)";

                command.Parameters.Add(new SqlParameter("Id", student.ID));
                return (int)command.ExecuteScalar();
            }
        }
    }
}
