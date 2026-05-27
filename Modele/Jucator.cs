using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Modele
{
    public enum NivelJucator { Incepator, Intermediar, Avansat }

    public class Jucator : INotifyPropertyChanged
    {
        private string nume;
        private int scor;

        public string Nume
        {
            get => nume;
            set { nume = value; OnPropertyChanged(); }
        }

        public int Scor
        {
            get => scor;
            set { scor = value; OnPropertyChanged(); }
        }

        public int RaspunsuriCorecte { get; set; }
        public int RaspunsuriGresite { get; set; }
        public NivelJucator Nivel { get; set; }

        public Jucator(string nume)
        {
            Nume = nume;
            Scor = 0;
            RaspunsuriCorecte = 0;
            RaspunsuriGresite = 0;
            Nivel = NivelJucator.Incepator;
        }

        public void AdaugaPuncte(int puncte)
        {
            Scor += puncte;
            RaspunsuriCorecte++;
            ActualizeazaNivel();
        }

        public void RaspunsGresit()
        {
            RaspunsuriGresite++;
        }

        private void ActualizeazaNivel()
        {
            if (Scor >= 80) Nivel = NivelJucator.Avansat;
            else if (Scor >= 50) Nivel = NivelJucator.Intermediar;
            else Nivel = NivelJucator.Incepator;
        }

        public override string ToString()
        {
            return $"{Nume} - Scor: {Scor} | Nivel: {Nivel}";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}