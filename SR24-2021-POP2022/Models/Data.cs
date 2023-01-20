using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using SR24_2021_POP2022.Services;
using SR24_2021_POP2022.Models;

namespace SR24_2021_POP2022.Models
{
    sealed class Data
    {
        public static readonly string CONNECTION_STRING = @"Data Source=PANA\SQLEXPRESS;Initial Catalog=SR242021POP;Integrated Security=True";
        
        private static readonly Data instance = new Data();
        IUserService userService;
        IProfessorService professorService;
        ISkolaService skolaService;
        IStudentService studentService;
        ICasoviService casoviService;
        IAdresaService adresaService;

        private Data()
        {
            userService = new UserService();
            adresaService = new AdresaService();
            professorService = new ProfessorService();
            skolaService = new SkolaService();
            jezikService = new JezikService();
            studentService = new StudentService();
            casoviService = new CasoviService();

        }

        public static Data Instance
        {
            get
            {
                return instance;
            }
        }

        public ObservableCollection<RegistrovaniKorisnik> Korisnici { get; set; }
        public ObservableCollection<Profesor> Profesori { get; set; }

        public ObservableCollection<Student> Studenti { get; set; }
        
        public ObservableCollection<Skola> Skole { get; set; }

        public ObservableCollection<Adresa> Adrese { get; set; }

        public ObservableCollection<Casovi> Casovi { get; set; }
        public ObservableCollection<Jezik> Jezici { get; set; }

        public void Initialize()
        {
            Korisnici = new ObservableCollection<RegistrovaniKorisnik>();
            Studenti = new ObservableCollection<Student>();
            Profesori = new ObservableCollection<Profesor>();
            Casovi = new ObservableCollection<Casovi>();
            Adrese = new ObservableCollection<Adresa>();
            Skole = new ObservableCollection<Skola>();
            Jezici = new ObservableCollection<Jezik>();
        }

        public int SacuvajEntitet(Object obj)
        {
            if (obj is RegistrovaniKorisnik)
            {
                return userService.SaveUser(obj);
            }
            else if (obj is Profesor)
            {
                return professorService.SaveProfesor();
            }
            else if (obj is Student)
            {
                return studentService.SaveStudent(obj);
            }
            else if (obj is Casovi)
            {
                return casoviService.SaveCasovi(obj);
            }
            else if (obj is Adresa)
            {
                return adresaService.SaveAdresa(obj);
            }
            else if (obj is Skola)
            {
                return skolaService.SaveSkola(obj);
            }
            else if (obj is Jezik)
            {
                return jezikService.SaveJezik(obj);
            }
            return -1;
        }

        public void CitanjeEntiteta(string filename)
        {
            if (filename.Contains("korisnici"))
            {
                userService.ReadUsers();
            }
            else if (filename.Contains("profesori"))
            {
                professorService.ReadUsers();
            }
            else if (filename.Contains("studenti"))
            {
                studentService.ReadUsers();
            }
        }

        public void SacuvajUBin(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(@"../../Resources/" + filename, FileMode.Create, FileAccess.Write))
            {
                if (filename.Contains("korisnici"))
                {
                    formatter.Serialize(stream, Data.Instance.Korisnici);
                }
                else if (filename.Contains("profesori"))
                {
                    formatter.Serialize(stream, Data.Instance.Profesori);
                }
                else if (filename.Contains("studenti"))
                {
                    formatter.Serialize(stream, Data.Instance.Studenti);
                }
            }
        }

        public void CitajIzBin(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(@"../../Resources/" + filename, FileMode.Open, FileAccess.Read))
            {
                if (filename.Contains("korisnici"))
                {
                    Korisnici = (ObservableCollection<RegistrovaniKorisnik>)formatter.Deserialize(stream);
                }
                else if (filename.Contains("profesori"))
                {
                    Profesori = (ObservableCollection<Profesor>)formatter.Deserialize(stream);
                }
                else if (filename.Contains("studenti"))
                {
                    Studenti = (ObservableCollection<Student>)formatter.Deserialize(stream);
                }
            }
        }

        public void ObrisiKorisnika(string email)
        {
            userService.DeleteUser(email);
            //userService.SaveUsers("korisnici.txt");
        }
    }
}
