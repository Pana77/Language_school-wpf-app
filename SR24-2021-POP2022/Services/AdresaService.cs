using System;
using SR24_2021_POP2022.Models;
using SR24_2021_POP2022.MyExceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace SR24_2021_POP2022.Services
{
    class AdresaService : IAdresaService
    {
        public void DeleteAdresa(int id)
        {
            Adresa adresa = Data.Instance.Adrese.ToList().Find(adresa => adresa.ID.Equals(id));

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = @"update dbo.Adrese SET Aktivan = @Aktivan where Id = @Id";
                cmd.Parameters.Add(new SqlParameter("Aktivan", adresa.Aktivan));
                cmd.Parameters.Add(new SqlParameter("Id", adresa.ID));

                cmd.ExecuteNonQuery();
            }
        }
        public void ReadAdresa()
        {
            Data.Instance.Adrese = new ObservableCollection<Adresa>();
            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"Select * from Adrese where Aktivan=1";

                SqlDataAdapter read = cmd.ExecuteReader();

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
