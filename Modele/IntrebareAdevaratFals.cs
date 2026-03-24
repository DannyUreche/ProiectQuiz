
namespace Modele
{
    public class IntrebareAdevaratFals : Intrebare
    {
        public bool Raspuns { get; set; }

        public IntrebareAdevaratFals(string text, bool raspuns,
            int puncte = 5) : base(text, puncte)
        {
            Raspuns = raspuns;
        }

        public override bool VerificaRaspuns(string raspunsUtilizator)
        {
            raspunsUtilizator = raspunsUtilizator.ToLower().Trim();
            if (raspunsUtilizator == "a") return Raspuns == true;
            if (raspunsUtilizator == "f") return Raspuns == false;
            return false;
        }
    }
}