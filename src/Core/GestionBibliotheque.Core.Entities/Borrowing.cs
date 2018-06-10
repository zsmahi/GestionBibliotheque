using System;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// La gestion des emprunts
    /// </summary>
    public class Borrowing
    {
        /// <summary>
        /// l'ID de l'utilisateur qui a emprunté le livre
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// L'ID du livre emprunté
        /// </summary>
        public int BookId { get; set; }
        /// <summary>
        /// Date d'emprunt du livre
        /// </summary>
        public DateTime BorrowingDateTime { get; set; }
        /// <summary>
        /// Date de rendu du livre
        /// </summary>
        public DateTime ReturnDateTime { get; set; }
        /// <summary>
        /// L'utilisateur qui a emprunté ce livre
        /// </summary>
        public virtual User User {get;set;}
        /// <summary>
        /// Le livre emprunté par cet utilisateur
        /// </summary>
        public virtual Book Book { get; set; }
    }
}