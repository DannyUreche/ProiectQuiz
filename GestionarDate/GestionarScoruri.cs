using Modele;

namespace GestionarDate
{
    public class GestionarScoruri
    {
        private const string FISIER_SCORURI = "scoruri.txt";

        public void SalveazaScor(Jucator jucator)
        {
            using (StreamWriter writer = new StreamWriter(FISIER_SCORURI, append: true))
            {
                writer.WriteLine($"{jucator.Nume},{jucator.Scor},{jucator.Nivel}");
            }
        }

        public List<Jucator> CitesteScoruriSortate()
        {
            List<Jucator> jucatori = new List<Jucator>();

            if (!File.Exists(FISIER_SCORURI))
                return jucatori;

            foreach (string linie in File.ReadAllLines(FISIER_SCORURI))
            {
                string[] date = linie.Split(',');
                if (date.Length == 3)
                {
                    Jucator j = new Jucator(date[0]);
                    j.Scor = int.Parse(date[1]);
                    jucatori.Add(j);
                }
            }

            // LINQ - sortare descrescator dupa scor
            return jucatori.OrderByDescending(j => j.Scor).ToList();
        }
    }
}