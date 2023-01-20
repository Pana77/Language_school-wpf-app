using SR24_2021_POP2022.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AllStudentsWindow.xaml
    /// </summary>
    public partial class AllStudentsWindow : Window
    {
        ICollectionView view;
        public AllStudentsWindow()
        {
            InitializeComponent();

            //dgProfesori.ItemsSource = null;
            //dgProfesori.ItemsSource = Data.Instance.Korisnici;
            view = CollectionViewSource.GetDefaultView(Data.Instance.Korisnici);
            view.Filter = CustomFilter;
            dgStudenti.ItemsSource = view;
        }

        private bool CustomFilter(object obj)
        {
            RegistrovaniKorisnik k = obj as RegistrovaniKorisnik;
            if (k.TipKorisnika.Equals(ETipKorisnika.STUDENT) && k.Aktivan)
            {
                if (txtPretraga.Text != "")
                {
                    return k.Email.Contains(txtPretraga.Text);
                }
                return true;
            }
            return false;
        }

        private void miDodajStudenta_Click(object sender, RoutedEventArgs e)
        {
            RegistrovaniKorisnik k = new RegistrovaniKorisnik();
            AddEditStudentsWindow addEditStudentsWindow = new AddEditStudentsWindow(EStatus.DODAJ, k);

            addEditStudentsWindow.ShowDialog();
            view.Refresh();
        }

        private void miIzmeniStudenta_Click(object sender, RoutedEventArgs e)
        {
            // proveriti da li je nesto uopste selektovano u tabeli
            // ako nije, ispisi poruku korisniku
            RegistrovaniKorisnik k = (RegistrovaniKorisnik)dgStudenti.SelectedItem;
            //kopija originalnog korisnika
            RegistrovaniKorisnik kopijaKorisnika = new RegistrovaniKorisnik();
            kopijaKorisnika.Ime = k.Ime;
            kopijaKorisnika.Prezime = k.Prezime;
            kopijaKorisnika.Email = k.Email;
            kopijaKorisnika.TipKorisnika = k.TipKorisnika;
            kopijaKorisnika.Aktivan = k.Aktivan;

            AddEditStudentsWindow addEditStudentsWindow = new AddEditStudentsWindow(EStatus.IZMENI, k);


            if ((bool)!addEditStudentsWindow.ShowDialog())
            {
                //kopiju postavljam umesto izmenjenog objekta
                int index = Data.Instance.Korisnici.ToList().FindIndex(ko => ko.Email.Equals(k.Email));
                Data.Instance.Korisnici[index] = kopijaKorisnika;
            }
            view.Refresh();
        }

        private void miObrisiStudenta_Click(object sender, RoutedEventArgs e)
        {
            RegistrovaniKorisnik k = (RegistrovaniKorisnik)dgStudenti.SelectedItem;
            Data.Instance.ObrisiKorisnika(k.Email);
            view.Refresh();
        }

        private void txtPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            view.Refresh();
        }

        private void dgStudenti_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName.Equals("Error"))
            {
                e.Column.Visibility = Visibility.Collapsed;
            }
        }
    }
}
