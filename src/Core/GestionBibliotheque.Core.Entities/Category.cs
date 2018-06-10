using System.Collections.Generic;
using GestionBibliotheque.Core.Interfaces;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// La catégorie du Livre
    /// </summary>
    public class Category : BaseEntity,IAggregationRoot
    {
        public Category() : base()
        {
            BooksCategory = new HashSet<BookCategory>();
        }
        /// <summary>
        /// Liste des livres de cette categorie
        /// </summary>
        public virtual ICollection<BookCategory> BooksCategory {get;set;}
    }
}