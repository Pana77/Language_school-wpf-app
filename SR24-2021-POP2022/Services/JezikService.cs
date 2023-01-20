using SR24_2021_POP2022.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR24_2021_POP2022.Services
{
    internal class JezikService
    {
        public void DeleteJezik(int id)
        {
            Jezik jezik = Data.Instance.Jezici.ToList().Find(jezik => jezik.ID.Equals(id));

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = @"update dbo.Jezici SET Aktivan = @Aktivan where Id = @Id";
                cmd.Parameters.Add(new SqlParameter("Aktivan", jezik.Aktivan));
                cmd.Parameters.Add(new SqlParameter("Id", jezik.Id));

                cmd.ExecuteNonQuery();
            }
        }
        public void ReadJezik()
        {
            Data.Instance.Jezici = new ObservableCollection<Jezik>();
            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"Select * from Jezici where Aktivan=1";

                SqlDataReader read = cmd.ExecuteReader();

                while (read.Read())
                {
                    Data.Instance.Adrese.Add(new Adresa
                    {
                        ID = read.GetString(0),
                        Ulica = read.GetString(1),
                        Broj = read.GetString(2),
                        Grad = read.GetString(3),
                        Drzava = read.GetString(4),
                        Aktivan = read.GetString(5),
                    });
                }
                read.close();
            }
        }

        public int SaveJezik(object obj)
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
