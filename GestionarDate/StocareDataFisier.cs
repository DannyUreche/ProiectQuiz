using Modele;

namespace GestionarDate
{
    public class StocareDataFisier : IStocareDate
    {
        private const string FISIER_CATEGORII = "categorii.txt";
        private const string FISIER_JUCATORI = "jucatori.txt";
        private const char SEPARATOR = '|';
        private const char SEPARATOR_VARIANTE = ';';

        public StocareDataFisier()
        {
            File.Open(FISIER_CATEGORII, FileMode.OpenOrCreate).Close();
            File.Open(FISIER_JUCATORI, FileMode.OpenOrCreate).Close();
        }

        public void SalveazaCategorie(Categorie categorie)
        {
            using (StreamWriter writer = new StreamWriter(FISIER_CATEGORII, append: true))
            {
                foreach (var intrebare in categorie.Intrebari)
                {
                    if (intrebare is IntrebareUnica iu)
                    {
                        string variante = string.Join(SEPARATOR_VARIANTE, iu.Variante);
                        writer.WriteLine($"{categorie.Nume}{SEPARATOR}{categorie.Dificultate}{SEPARATOR}Unica{SEPARATOR}{iu.Text}{SEPARATOR}{iu.Puncte}{SEPARATOR}{iu.IndexRaspunsCorect}{SEPARATOR}{variante}");
                    }
                    else if (intrebare is IntrebareAdevaratFals iaf)
                    {
                        writer.WriteLine($"{categorie.Nume}{SEPARATOR}{categorie.Dificultate}{SEPARATOR}AdevaratFals{SEPARATOR}{iaf.Text}{SEPARATOR}{iaf.Puncte}{SEPARATOR}{iaf.Raspuns}");
                    }
                }
            }
        }

        public List<Categorie> GetCategorii()
        {
            List<Categorie> categorii = new List<Categorie>();

            if (!File.Exists(FISIER_CATEGORII))
                return categorii;

            using (StreamReader reader = new StreamReader(FISIER_CATEGORII))
            {
                string linie;
                while ((linie = reader.ReadLine()) != null)
                {
                    string[] date = linie.Split(SEPARATOR);
                    if (date.Length < 5) continue;

                    string numeCategorie = date[0];
                    Dificultate dificultate = Enum.Parse<Dificultate>(date[1]);
                    string tip = date[2];

                    Categorie categorie = categorii.FirstOrDefault(c => c.Nume == numeCategorie);
                    if (categorie == null)
                    {
                        categorie = new Categorie(numeCategorie, dificultate);
                        categorii.Add(categorie);
                    }

                    if (tip == "Unica")
                    {
                        string text = date[3];
                        int puncte = int.Parse(date[4]);
                        int indexCorect = int.Parse(date[5]);
                        List<string> variante = date[6].Split(SEPARATOR_VARIANTE).ToList();
                        categorie.AdaugaIntrebare(new IntrebareUnica(text, variante, indexCorect, puncte));
                    }
                    else if (tip == "AdevaratFals")
                    {
                        string text = date[3];
                        int puncte = int.Parse(date[4]);
                        bool raspuns = bool.Parse(date[5]);
                        categorie.AdaugaIntrebare(new IntrebareAdevaratFals(text, raspuns, puncte));
                    }
                }
            }

            return categorii;
        }

        public void SalveazaJucator(Jucator jucator)
        {
            using (StreamWriter writer = new StreamWriter(FISIER_JUCATORI, append: true))
            {
                writer.WriteLine($"{jucator.Nume}{SEPARATOR}{jucator.Scor}{SEPARATOR}{jucator.Nivel}{SEPARATOR}{jucator.RaspunsuriCorecte}{SEPARATOR}{jucator.RaspunsuriGresite}");
            }
        }

        public List<Jucator> GetJucatori()
        {
            List<Jucator> jucatori = new List<Jucator>();

            if (!File.Exists(FISIER_JUCATORI))
                return jucatori;

            using (StreamReader reader = new StreamReader(FISIER_JUCATORI))
            {
                string linie;
                while ((linie = reader.ReadLine()) != null)
                {
                    string[] date = linie.Split(SEPARATOR);
                    if (date.Length < 5) continue;

                    Jucator j = new Jucator(date[0]);
                    j.Scor = int.Parse(date[1]);
                    j.RaspunsuriCorecte = int.Parse(date[3]);
                    j.RaspunsuriGresite = int.Parse(date[4]);
                    jucatori.Add(j);
                }
            }

            return jucatori.OrderByDescending(j => j.Scor).ToList();
        }
    }
}