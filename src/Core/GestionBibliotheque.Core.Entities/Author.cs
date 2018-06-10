using System.Collections.Generic;
using GestionBibliotheque.Core.Interfaces;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// L'auteur
    /// </summary>
    public class Author : BaseEntity, IAggregationRoot
    {
       public Author(): base()
        {
            BooksAuthor = new HashSet<AuthorBook>();
        }
        /// <summary>
        /// Liste des livres écrits par cet auteur
        /// </summary>
        public virtual ICollection<AuthorBook> BooksAuthor { get; set; }
    }
}