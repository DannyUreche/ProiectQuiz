namespace Modele
{
    public enum Dificultate { Usor, Mediu, Greu }

    public class Categorie
    {
        public string Nume { get; set; }
        public Dificultate Dificultate { get; set; }
        public List<Intrebare> Intrebari { get; set; }

        public int PunctePerIntrebare => Intrebari.Count > 0 ? 100 / Intrebari.Count : 10;

        public Categorie(string nume, Dificultate dificultate)
        {
            Nume = nume;
            Dificultate = dificultate;
            Intrebari = new List<Intrebare>();
        }

        public void AdaugaIntrebare(Intrebare intrebare)
        {
            Intrebari.Add(intrebare);
        }

        public List<Intrebare> CautaIntrebari(string text)
        {
            return Intrebari
                .Where(i => i.Text.ToLower().Contains(text.ToLower()))
                .ToList();
        }

        public List<Intrebare> GetIntrebariDupaPuncte(int puncte)
        {
            return Intrebari
                .Where(i => i.Puncte == puncte)
                .ToList();
        }
    }
}