using System.Collections.Generic;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// L'utilisateur ou l'étudiant
    /// </summary>
    public class User : Person
    {
        public User() : base()
        {
            Borrowings = new HashSet<Borrowing>();
        }
        /// <summary>
        /// l'email de l'étudiant
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Numéro de téléphone de l'étudiant
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// L'Id utilisé lors de l'authentification, Voir section Identity
        /// </summary>
        public string ExternalUserIdentity{ get; set; }
        /// <summary>
        /// Le nom d'utilisateur du User, Voir section identity
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Id du Role de cet utilisateur
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// Le Role de l'utilisateur en cours
        /// </summary>
        public Role Role { get; set; }
        /// <summary>
        /// Les livres empruntés par cet utilisateur
        /// </summary>
        public virtual ICollection<Borrowing> Borrowings {get;set;}
    }
}