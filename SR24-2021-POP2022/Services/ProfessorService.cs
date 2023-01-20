using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SR24_2021_POP2022.Models;

namespace SR24_2021_POP2022.Services
{
    class ProfessorService : IProfessorService
    {


        ObservableCollection<Skola> skole = new ObservableCollection<Skola>();
        ObservableCollection<Adresa> adrse = new ObservableCollection<Adresa>();

        public void DeleteProfesor(string email)
        {
            throw new NotImplementedException();
        }

        public List<RegistrovaniKorisnik> ListAllProfesor()
        {
            throw new NotImplementedException();
        }

        public void ReadProfesor()
        {
            Data.Instance.Skole = new ObservableCollection<Skola>();
            ReadProfesor();

            Data.Instance.Profesori = new ObservableCollection<Profesor>();
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
                        TipKorisnika = ETipKorisnika.PROFESOR,
                        Pol = EPol.MUSKI
                    };
                    Data.Instance.Korisnici.Add(korisnik);
                }
            }

        }

        public int SaveProfesor(Object obj)
        {

            Profesor profesor = obj as Profesor;

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();

                command.CommandText = @"insert into dbo.Profesori(Id)
                output inserted.id values(@Id)";

                command.Parameters.Add(new SqlParameter("Id", profesor.ID));
                return (int)command.ExecuteScalar();
            }
        }
    }
}
