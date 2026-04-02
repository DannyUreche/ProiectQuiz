using Modele;

namespace GestionarDate
{
    public interface IStocareDate
    {
        void SalveazaCategorie(Categorie categorie);
        List<Categorie> GetCategorii();
        void SalveazaJucator(Jucator jucator);
        List<Jucator> GetJucatori();
    }
}