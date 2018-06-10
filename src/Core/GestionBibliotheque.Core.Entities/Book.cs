using System.Collections.Generic;
using GestionBibliotheque.Core.Interfaces;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// Objet livre
    /// </summary>
    public class Book : BaseEntity, IAggregationRoot
    {
        /// <summary>
        /// Constructeur : par défaut on mets une copie du livre lors de son son ajout
        /// </summary>
        public Book() : base()
        {
            CopiesNumber = 1;
            AuthorsBook = new HashSet<AuthorBook>();
            CategoriesBook = new HashSet<BookCategory>();
            Borrowings = new HashSet<Borrowing>();
        }
        /// <summary>
        /// Numero ISBN (International Standard Book Number / Numéro International Normalisé du Livre)
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// Numero ISSN (nternational Standard Serial Number / Numéro International Normalisé de Publications en Série)
        /// </summary>
        public string ISSN { get; set; }
        /// <summary>
        /// Nombre d'exemplaires du livre en cours
        /// </summary>
        public int CopiesNumber { get; set; }
        /// <summary>
        /// Illustration du livre ( Cover ou n'importe quel image du livre )
        /// </summary>
        public byte[] Image { get; set; }
        /// <summary>
        /// Listes des auteurs qui ont écrit ce livre
        /// </summary>
        public virtual ICollection<AuthorBook> AuthorsBook { get; set; }
        /// <summary>
        /// Liste des categories de ce livre
        /// </summary>
        public virtual ICollection<BookCategory> CategoriesBook {get;set;}
        /// <summary>
        /// Les utilisateurs qui ont emprunté ce livre
        /// </summary>
        public virtual ICollection<Borrowing> Borrowings {get;set;}
    }
}