namespace Modele
{
    public enum NivelJucator { Incepator, Intermediar, Avansat }

    public class Jucator
    {
        public string Nume { get; set; }
        public int Scor { get; set; }
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
            if (Scor >= 100)
                Nivel = NivelJucator.Avansat;
            else if (Scor >= 50)
                Nivel = NivelJucator.Intermediar;
            else
                Nivel = NivelJucator.Incepator;
        }

        public override string ToString()
        {
            return $"{Nume} - Scor: {Scor} | Nivel: {Nivel} " +
                   $"(Corecte: {RaspunsuriCorecte}, " +
                   $"Gresite: {RaspunsuriGresite})";
        }
    }
}