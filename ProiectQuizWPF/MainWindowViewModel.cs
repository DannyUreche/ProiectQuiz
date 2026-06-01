using Modele;
using GestionarDate;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProiectQuizWPF
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        // Stocare date
        public StocareDataFisier Stocare { get; set; } = new StocareDataFisier();

        // Colectii
        public ObservableCollection<Jucator> Jucatori { get; set; }
            = new ObservableCollection<Jucator>();

        public List<Categorie> Categorii { get; set; }
            = new List<Categorie>();

        // Jucator selectat in DataGrid
        private Jucator? jucatorSelectat;
        public Jucator? JucatorSelectat
        {
            get => jucatorSelectat;
            set { jucatorSelectat = value; OnPropertyChanged(); }
        }

        // Categorie selectata in ComboBox
        private Categorie? categorieSelectata;
        public Categorie? CategorieSelectata
        {
            get => categorieSelectata;
            set { categorieSelectata = value; OnPropertyChanged(); }
        }

        // Notificare UI
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}