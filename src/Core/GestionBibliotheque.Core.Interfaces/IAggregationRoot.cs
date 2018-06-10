namespace GestionBibliotheque.Core.Interfaces
{
    /// <summary>
    /// Interface utilisée pour une vue en racine 
    /// (Livre -> liste des auteurs; 
    /// auteur -> liste des livres , 
    /// livre -> liste des personnes qui l'ont emprunté, 
    /// Personne -> liste des livres empruntés)
    /// </summary>
    public interface IAggregationRoot
    {
         
    }
}