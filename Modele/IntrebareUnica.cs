
namespace Modele
{
    public class IntrebareUnica : Intrebare
    {
        public List<string> Variante { get; set; }
        public int IndexRaspunsCorect { get; set; }

        public IntrebareUnica(string text, List<string> variante,
            int indexCorect, int puncte = 10) : base(text, puncte)
        {
            Variante = variante;
            IndexRaspunsCorect = indexCorect;
        }

        public override bool VerificaRaspuns(string raspunsUtilizator)
        {
            if (int.TryParse(raspunsUtilizator, out int index))
                return index == IndexRaspunsCorect;
            return false;
        }
    }
}