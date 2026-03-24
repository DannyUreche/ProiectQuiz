

namespace Modele
{
    public enum Dificultate { Usor, Mediu, Greu }

    public class Categorie
    {
        public string Nume { get; set; }
        public Dificultate Dificultate { get; set; }
        public List<Intrebare> Intrebari { get; set; }

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

        // LINQ - cauta intrebari dupa text
        public List<Intrebare> CautaIntrebari(string text)
        {
            return Intrebari
                .Where(i => i.Text.ToLower().Contains(text.ToLower()))
                .ToList();
        }

        // LINQ - intrebari dupa puncte
        public List<Intrebare> GetIntrebariDupaPuncte(int puncte)
        {
            return Intrebari
                .Where(i => i.Puncte == puncte)
                .ToList();
        }
    }
}