using Modele;
using System.Windows;
using System.Windows.Media;

namespace ProiectQuizWPF
{
    public partial class MainWindow : Window
    {
        private const int LUNGIME_MAX_NUME = 20;
        private List<Categorie> categorii = new List<Categorie>();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Meniu
        private void OnMenuAdauga(object sender, RoutedEventArgs e)
        {
            panelAdauga.Visibility = Visibility.Visible;
            panelCauta.Visibility = Visibility.Collapsed;
        }

        private void OnMenuCauta(object sender, RoutedEventArgs e)
        {
            panelAdauga.Visibility = Visibility.Collapsed;
            panelCauta.Visibility = Visibility.Visible;
        }

        // Validare
        private bool ValideazaDate()
        {
            bool esteValid = true;

            // Reset
            lblNume.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            tbErrNume.Visibility = Visibility.Collapsed;

            // Validare nume
            if (string.IsNullOrWhiteSpace(txtNume.Text) || txtNume.Text.Length > LUNGIME_MAX_NUME)
            {
                lblNume.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
                tbErrNume.Visibility = Visibility.Visible;
                esteValid = false;
            }

            return esteValid;
        }

        private Dificultate GetDificultateSelectata()
        {
            if (rbMediu.IsChecked == true) return Dificultate.Mediu;
            if (rbGreu.IsChecked == true) return Dificultate.Greu;
            return Dificultate.Usor;
        }

        // Adauga
        private void OnAdauga(object sender, RoutedEventArgs e)
        {
            if (!ValideazaDate()) return;

            Dificultate dificultate = GetDificultateSelectata();
            Categorie categorie = new Categorie(txtNume.Text, dificultate);
            categorii.Add(categorie);

            tbSucces.Visibility = Visibility.Visible;
        }

        // Reset
        private void OnReset(object sender, RoutedEventArgs e)
        {
            txtNume.Text = string.Empty;
            rbUsor.IsChecked = true;
            ckbTimer.IsChecked = false;
            ckbImagini.IsChecked = false;
            ckbLeaderboard.IsChecked = false;

            lblNume.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            tbErrNume.Visibility = Visibility.Collapsed;
            tbSucces.Visibility = Visibility.Collapsed;
        }

        // Cauta
        private void OnCauta(object sender, RoutedEventArgs e)
        {
            string nume = txtCauta.Text.ToLower().Trim();

            List<Categorie> rezultate = categorii
                .Where(c => c.Nume.ToLower().Contains(nume))
                .ToList();

            if (rezultate.Count == 0)
            {
                tbErrCauta.Visibility = Visibility.Visible;
                dgCategorii.Visibility = Visibility.Collapsed;
            }
            else
            {
                tbErrCauta.Visibility = Visibility.Collapsed;
                dgCategorii.Visibility = Visibility.Visible;
                dgCategorii.ItemsSource = rezultate;
            }
        }
    }
}