using Modele;
using System.Windows;
using System.Windows.Media;

namespace ProiectQuizWPF
{
    public partial class MainWindow : Window
    {
        private const int LUNGIME_MAX_NUME = 20;
        private const int DIFICULTATE_MIN = 1;
        private const int DIFICULTATE_MAX = 3;

        private List<Categorie> categorii = new List<Categorie>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool ValideazaDate(out Dificultate dificultate)
        {
            bool esteValid = true;
            dificultate = Dificultate.Usor;

            // Reset culori
            lblNume.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            lblDificultate.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            tbErrNume.Visibility = Visibility.Collapsed;
            tbErrDificultate.Visibility = Visibility.Collapsed;

            // Validare nume
            if (string.IsNullOrWhiteSpace(txtNume.Text) || txtNume.Text.Length > LUNGIME_MAX_NUME)
            {
                lblNume.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
                tbErrNume.Visibility = Visibility.Visible;
                esteValid = false;
            }

            // Validare dificultate
            if (!int.TryParse(txtDificultate.Text, out int diff) ||
                diff < DIFICULTATE_MIN || diff > DIFICULTATE_MAX)
            {
                lblDificultate.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
                tbErrDificultate.Visibility = Visibility.Visible;
                esteValid = false;
            }
            else
            {
                dificultate = diff switch
                {
                    2 => Dificultate.Mediu,
                    3 => Dificultate.Greu,
                    _ => Dificultate.Usor
                };
            }

            return esteValid;
        }

        private void OnAdauga(object sender, RoutedEventArgs e)
        {
            if (!ValideazaDate(out Dificultate dificultate))
                return;

            Categorie categorie = new Categorie(txtNume.Text, dificultate);
            categorii.Add(categorie);

            tbSucces.Visibility = Visibility.Visible;
        }

        private void OnReset(object sender, RoutedEventArgs e)
        {
            txtNume.Text = string.Empty;
            txtDificultate.Text = string.Empty;

            lblNume.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            lblDificultate.Foreground = new SolidColorBrush(Color.FromRgb(137, 180, 250));
            tbErrNume.Visibility = Visibility.Collapsed;
            tbErrDificultate.Visibility = Visibility.Collapsed;
            tbSucces.Visibility = Visibility.Collapsed;
        }
    }
}