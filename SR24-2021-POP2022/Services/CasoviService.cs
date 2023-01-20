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
    class CasoviService : ICasoviService
    {
        public void DeleteCasovi(string id)
        {
            Casovi casovi = Data.Instance.Casovi.ToList().Find(Casovi => Casovi.ID.Equals(id));

            if (casovi == null)
                throw new UserNotFoundException($"Ne postoji cas sa tim id-om{id}");
            casovi.Aktivan = false;

            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = @"update dbo.Casovi SET Aktivan = @Aktivan where Id = @Id";
                cmd.Parameters.Add(new SqlParameter("Aktivan", casovi.Aktivan));
                cmd.Parameters.Add(new SqlParameter("Id", casovi.ID));

                cmd.ExecuteNonQuery();
            }
        }
        public void ReadAdresa()
        {
            Data.Instance.Casovi = new ObservableCollection<Casovi>();
            using (SqlConnection conn = new SqlConnection(Data.CONNECTION_STRING))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"Select * from Casovi where Aktivan=1";

                SqlDataAdapter reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ID = reader.GetString(0),
                        Ulica = reader.GetString(1),
                        Broj = reader.GetString(2),
                        Grad = reader.GetString(3),
                        Drzava = reader.GetString(4),
                        Aktivan = reader.GetString(5),

                        Data.Instance.Casovi.Add(casovi);
                }
                reader.close();
            } 
        }
    }
    public int SaveCasovi(object obj)
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
