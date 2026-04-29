using Modele;
using System.Windows;

namespace ProiectQuizWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AfiseazaDate();
        }

        private void AfiseazaDate()
        {
            // Informatii categorie
            Categorie categorie = new Categorie("Geografie", Dificultate.Usor);
            categorie.AdaugaIntrebare(new IntrebareUnica(
                "Care este capitala Frantei?",
                new List<string> { "Londra", "Paris", "Berlin", "Roma" },
                indexCorect: 1
            ));
            categorie.AdaugaIntrebare(new IntrebareAdevaratFals(
                "Dunarea se varsa in Marea Neagra.",
                raspuns: true
            ));

            lblNumeCategorie.Content = $"Categorie: {categorie.Nume}";
            lblDificultate.Content = $"Dificultate: {categorie.Dificultate}";
            lblNrIntrebari.Content = $"Numar intrebari: {categorie.Intrebari.Count}";

            // Informatii jucator
            Jucator jucator = new Jucator("Andrei");
            lblNumeJucator.Content = $"Nume: {jucator.Nume}";
            lblScor.Content = $"Scor: {jucator.Scor}";
            lblNivel.Content = $"Nivel: {jucator.Nivel}";
        }
    }
}