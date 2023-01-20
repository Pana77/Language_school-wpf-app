using SR24_2021_POP2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SR24_2021_POP2022.Windows
{
    /// <summary>
    /// Interaction logic for AddEditStudentsWindow.xaml
    /// </summary>
    public partial class AddEditStudentsWindow : Window
    {
        private RegistrovaniKorisnik selektovaniKorisnik;
        private EStatus selektovaniStatus;

        public AddEditStudentsWindow(EStatus status, RegistrovaniKorisnik korisnik)
        {
            InitializeComponent();
            selektovaniKorisnik = korisnik;
            selektovaniStatus = status;

            this.DataContext = korisnik;  //setujem binding source

            //dinamcki kreiram sadrzaj combobox-a
            cmbTipKorisnika.ItemsSource = Enum.GetValues(typeof(ETipKorisnika));


            if (status.Equals(EStatus.DODAJ))
            {
                this.Title = "Dodaj studenta";
            }
            else
            {
                txtEmail.IsEnabled = false;
                this.Title = "Izmeni studenta";
            }
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private bool isValid()
        {
            return !Validation.GetHasError(txtEmail) && !Validation.GetHasError(txtIme);
        }

        private void btnSacuvaj_Click(object sender, RoutedEventArgs e)
        {

            if (isValid())
            {
                //kreiram studenta
                Student student = new Student
                {
                    Korisnik = selektovaniKorisnik
                };

                //podatke cuvam u listu pa u fajlove/bazu
                if (selektovaniStatus.Equals(EStatus.DODAJ))
                {
                    selektovaniKorisnik.Aktivan = true;
                    Data.Instance.Korisnici.Add(selektovaniKorisnik);
                    Data.Instance.Studenti.Add(student);
                }

                int id = Data.Instance.SacuvajEntitet(selektovaniKorisnik);
                student.ID = id; //setujem strani kljuc
                Data.Instance.SacuvajEntitet(student);

                this.DialogResult = true;

            }
            //zatvaram formu za kreiranje profesora
            this.Close();
        }
    }
}
