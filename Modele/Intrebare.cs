namespace Modele
{
    public abstract class Intrebare
    {
        public string Text { get; set; }
        public string? CaleImagine { get; set; }
        public int Puncte { get; set; }

        public Intrebare(string text, int puncte, string? caleImagine = null)
        {
            Text = text;
            Puncte = puncte;
            CaleImagine = caleImagine;
        }

        public abstract bool VerificaRaspuns(string raspunsUtilizator);
    }
}