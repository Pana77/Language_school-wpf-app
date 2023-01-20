using SR24_2021_POP2022.Models;
using SR24_2021_POP2022.MyExceptions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    class SkolaService
    {
        public void DeleteSkola(int id)
        {
            Skola skola = Data.Instance.Skole.ToList().Find(Skola => Skola.ID.Equals(id));

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = @"update dbo.Adrese SET Aktivan = @Aktivan where Id = @Id";
                cmd.Parameters.Add(new SqlParameter("Aktivan", skola.Aktivan));
                cmd.Parameters.Add(new SqlParameter("Id", skola.ID));

                cmd.ExecuteNonQuery();
            }
        }
        public void ReadSkola()
        {
            Data.Instance.Skole = new ObservableCollection<Skola>();
            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"Select * from Skole where Aktivan=1";

                SqlDataReader read = cmd.ExecuteReader(); 

                while (read.Read())
                {
                    Data.Instance.Skole.Add(new Skola
                    {
                        ID = read.GetString(0),
                        Naziv = read.GetString(1),
                        Adresa = Data.Instance.findAdresaId(read.GetString(2)),
                        Aktivan = read.GetBoolean(3)
                    });
                }
                read.close();
            }
        }

        public int SaveAdresa(object obj)
        {
            Adresa adresa = obj as Adresa;
            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"insert into dbo.Adrese(ulica,broj,grad,drzava,aktivan) output inserted.id VALUES(@Ulica, @Broj, @Grad, @Drzava, @Aktivan)";
                cmd.Parameters.Add(new SqlParameter("Ulica", adresa.Ulica));
                cmd.Parameters.Add(new SqlParameter("Broj", adresa.Broj));
                cmd.Parameters.Add(new SqlParameter("Grad", adresa.Grad));
                cmd.Parameters.Add(new SqlParameter("Drzava", adresa.Drzava));
                cmd.Parameters.Add(new SqlParameter("Aktivan", adresa.Aktivan));

                cmd.ExecuteNonQuery();
            }
        }

    }
}
}
