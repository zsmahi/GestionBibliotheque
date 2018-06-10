namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// Liste des livres écrits par un auteur ou liste auteurs qui ont écrit un livre
    /// </summary>
    public class AuthorBook : BaseEntity
    {
        /// <summary>
        /// L'ID de l'auteur
        /// </summary>
        public int AuthorId { get; set; }
        /// <summary>
        /// L'ID du livre
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// l'auteur qui a écrit le lvire
        /// </summary>
        public virtual Author Author { get; set; }
        /// <summary>
        /// Le livre écrit
        /// </summary>
        public virtual Book Book { get; set; }
    }
}