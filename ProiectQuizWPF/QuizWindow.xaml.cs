using Modele;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ProiectQuizWPF
{
    public partial class QuizWindow : Window
    {
        private Categorie categorie;
        private Jucator jucator;
        private int indexCurent = 0;
        private List<RadioButton> radioButtons = new List<RadioButton>();

        public QuizWindow(Categorie categorie, Jucator jucator)
        {
            InitializeComponent();
            this.categorie = categorie;
            this.jucator = jucator;
            AfiseazaIntrebare();
        }

        private void AfiseazaIntrebare()
        {
            if (indexCurent >= categorie.Intrebari.Count)
            {
                AfiseazaScorFinal();
                return;
            }

            Intrebare intrebare = categorie.Intrebari[indexCurent];

            lblCategorie.Content = categorie.Nume;
            lblProgres.Content = $"Intrebarea {indexCurent + 1} din {categorie.Intrebari.Count}";
            txtIntrebare.Text = intrebare.Text;

            tbFeedback.Visibility = Visibility.Collapsed;
            panelVariante.Children.Clear();
            radioButtons.Clear();

            if (intrebare is IntrebareUnica iu)
            {
                for (int i = 0; i < iu.Variante.Count; i++)
                {
                    RadioButton rb = new RadioButton
                    {
                        Content = $"{i + 1}. {iu.Variante[i]}",
                        Tag = i.ToString(),
                        Foreground = new SolidColorBrush(Color.FromRgb(205, 214, 244)),
                        FontSize = 14,
                        Margin = new Thickness(0, 8, 0, 0)
                    };
                    radioButtons.Add(rb);
                    panelVariante.Children.Add(rb);
                }
            }
            else if (intrebare is IntrebareAdevaratFals)
            {
                RadioButton rbA = new RadioButton
                {
                    Content = "Adevarat",
                    Tag = "a",
                    Foreground = new SolidColorBrush(Color.FromRgb(205, 214, 244)),
                    FontSize = 14,
                    Margin = new Thickness(0, 8, 0, 0)
                };
                RadioButton rbF = new RadioButton
                {
                    Content = "Fals",
                    Tag = "f",
                    Foreground = new SolidColorBrush(Color.FromRgb(205, 214, 244)),
                    FontSize = 14,
                    Margin = new Thickness(0, 8, 0, 0)
                };
                radioButtons.Add(rbA);
                radioButtons.Add(rbF);
                panelVariante.Children.Add(rbA);
                panelVariante.Children.Add(rbF);
            }

            btnUrmator.Content = indexCurent == categorie.Intrebari.Count - 1
                ? "Vezi scorul"
                : "Urmatoarea intrebare";
        }

        private void OnUrmator(object sender, RoutedEventArgs e)
        {
            RadioButton selectat = radioButtons.FirstOrDefault(rb => rb.IsChecked == true);

            if (selectat == null)
            {
                tbFeedback.Text = "Selectati un raspuns!";
                tbFeedback.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
                tbFeedback.Visibility = Visibility.Visible;
                return;
            }

            Intrebare intrebare = categorie.Intrebari[indexCurent];
            bool corect = intrebare.VerificaRaspuns(selectat.Tag.ToString());

            if (corect)
            {
                jucator.AdaugaPuncte(intrebare.Puncte);
                tbFeedback.Text = "Raspuns corect! ✓";
                tbFeedback.Foreground = new SolidColorBrush(Color.FromRgb(166, 227, 161));
            }
            else
            {
                jucator.RaspunsGresit();
                tbFeedback.Text = "Raspuns gresit! ✗";
                tbFeedback.Foreground = new SolidColorBrush(Color.FromRgb(243, 139, 168));
            }

            tbFeedback.Visibility = Visibility.Visible;

            indexCurent++;

            if (indexCurent >= categorie.Intrebari.Count)
            {
                btnUrmator.Content = "Vezi scorul";
                btnUrmator.Click -= OnUrmator;
                btnUrmator.Click += OnVeziScor;
            }
            else
            {
                System.Threading.Tasks.Task.Delay(1000).ContinueWith(_ =>
                {
                    Dispatcher.Invoke(AfiseazaIntrebare);
                });
            }
        }

        private void OnVeziScor(object sender, RoutedEventArgs e)
        {
            AfiseazaScorFinal();
        }

        private void AfiseazaScorFinal()
        {
            txtIntrebare.Text = $"Quiz terminat!\n\nJucator: {jucator.Nume}\nScor final: {jucator.Scor} puncte\nRaspunsuri corecte: {jucator.RaspunsuriCorecte}\nRaspunsuri gresite: {jucator.RaspunsuriGresite}\nNivel: {jucator.Nivel}";
            panelVariante.Children.Clear();
            tbFeedback.Visibility = Visibility.Collapsed;
            btnUrmator.Content = "Inchide";
            btnUrmator.Click -= OnUrmator;
            btnUrmator.Click -= OnVeziScor;
            btnUrmator.Click += (s, e) => Close();
        }
    }
}