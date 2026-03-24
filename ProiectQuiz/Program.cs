using Modele;
using GestionarDate;

namespace ProiectQuiz
{
    class Program
    {
        static List<Categorie> categorii = new List<Categorie>();
        static GestionarScoruri gestionarScoruri = new GestionarScoruri();

        static void Main()
        {
            bool rulare = true;
            while (rulare)
            {
                Console.WriteLine("\n=== QUIZ ===");
                Console.WriteLine("1. Adauga categorie");
                Console.WriteLine("2. Adauga intrebare");
                Console.WriteLine("3. Afiseaza categorii");
                Console.WriteLine("4. Cauta intrebari dupa categorie");
                Console.WriteLine("5. Afiseaza clasament");
                Console.WriteLine("0. Iesire");
                Console.Write("Alege optiunea: ");

                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        AdaugaCategorie();
                        break;
                    case "2":
                        AdaugaIntrebare();
                        break;
                    case "3":
                        AfiseazaCategorii();
                        break;
                    case "4":
                        CautaIntrebari();
                        break;
                    case "5":
                        AfiseazaClasament();
                        break;
                    case "0":
                        rulare = false;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            }
        }

        static void AdaugaCategorie()
        {
            Console.Write("Nume categorie: ");
            string nume = Console.ReadLine();

            Console.WriteLine("Dificultate (1=Usor, 2=Mediu, 3=Greu): ");
            string diff = Console.ReadLine();

            Dificultate dificultate;
            switch (diff)
            {
                case "2": dificultate = Dificultate.Mediu; break;
                case "3": dificultate = Dificultate.Greu; break;
                default: dificultate = Dificultate.Usor; break;
            }

            categorii.Add(new Categorie(nume, dificultate));
            Console.WriteLine("Categorie adaugata!");
        }

        static void AdaugaIntrebare()
        {
            if (categorii.Count == 0)
            {
                Console.WriteLine("Nu exista categorii! Adauga mai intai o categorie.");
                return;
            }

            Console.WriteLine("Categorii disponibile:");
            for (int i = 0; i < categorii.Count; i++)
                Console.WriteLine($"{i + 1}. {categorii[i].Nume}");

            Console.Write("Alege categoria: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index < 0 || index >= categorii.Count)
            {
                Console.WriteLine("Categorie invalida!");
                return;
            }

            Console.WriteLine("Tip intrebare (1=Unica, 2=Adevarat/Fals): ");
            string tip = Console.ReadLine();

            Console.Write("Text intrebare: ");
            string text = Console.ReadLine();

            if (tip == "1")
            {
                Console.Write("Numar variante (2-4): ");
                int nrVariante = int.Parse(Console.ReadLine());

                List<string> variante = new List<string>();
                for (int i = 0; i < nrVariante; i++)
                {
                    Console.Write($"Varianta {i + 1}: ");
                    variante.Add(Console.ReadLine());
                }

                Console.Write("Index raspuns corect (1-" + nrVariante + "): ");
                int indexCorect = int.Parse(Console.ReadLine()) - 1;

                categorii[index].AdaugaIntrebare(
                    new IntrebareUnica(text, variante, indexCorect));
            }
            else
            {
                Console.Write("Raspuns corect (A=Adevarat, F=Fals): ");
                string raspuns = Console.ReadLine().ToUpper();
                bool esteAdevarat = raspuns == "A";

                categorii[index].AdaugaIntrebare(
                    new IntrebareAdevaratFals(text, esteAdevarat));
            }

            Console.WriteLine("Intrebare adaugata!");
        }

        static void AfiseazaCategorii()
        {
            if (categorii.Count == 0)
            {
                Console.WriteLine("Nu exista categorii!");
                return;
            }

            foreach (var cat in categorii)
            {
                Console.WriteLine($"\nCategorie: {cat.Nume} | Dificultate: {cat.Dificultate} | Intrebari: {cat.Intrebari.Count}");
                foreach (var intrebare in cat.Intrebari)
                    Console.WriteLine($"  - {intrebare.Text} ({intrebare.Puncte} puncte)");
            }
        }

        static void CautaIntrebari()
        {
            Console.Write("Nume categorie de cautat: ");
            string nume = Console.ReadLine();

            Categorie gasita = categorii
                .FirstOrDefault(c => c.Nume.ToLower() == nume.ToLower());

            if (gasita == null)
            {
                Console.WriteLine("Categoria nu a fost gasita!");
                return;
            }

            Console.WriteLine($"\nIntrebari din categoria {gasita.Nume}:");
            foreach (var intrebare in gasita.Intrebari)
                Console.WriteLine($"  - {intrebare.Text}");
        }

        static void AfiseazaClasament()
        {
            List<Jucator> clasament = gestionarScoruri.CitesteScoruriSortate();

            if (clasament.Count == 0)
            {
                Console.WriteLine("Nu exista scoruri salvate!");
                return;
            }

            Console.WriteLine("\n=== CLASAMENT ===");
            for (int i = 0; i < clasament.Count; i++)
                Console.WriteLine($"{i + 1}. {clasament[i]}");
        }
    }
}