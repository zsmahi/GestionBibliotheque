namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// Liste des livres d'une catégorie ou liste de catégories d'un livre
    /// </summary>
    public class BookCategory : BaseEntity
    {
        /// <summary>
        /// l'ID du livre
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// L'ID de la catégorie
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Le livre en question
        /// </summary>
        public virtual Book Book { get; set; }
        /// <summary>
        /// La catégorie du livre en question
        /// </summary>
        public virtual Category Category {get;set;}
    }
}