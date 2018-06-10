using System.Collections.Generic;
using GestionBibliotheque.Core.Interfaces;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// Le role de l'utilisateur dans l'application
    /// L'utilisateur peut être soit:
    /// - Administrateur : il a accès à tout; il peut emprunter un livre, ajouter un livre, valider l'ajout d'un livre, modifier les paramètres.
    /// - Modérateur : il peut emprunter un livre, ajouter un livre, valider l'ajout d'un livre
    /// - Membre actif : il peut emprunter un livre, ajouter un livre
    /// - Membre : il peut emprunter un livre
    /// </summary>
    public class Role : BaseEntity , IAggregationRoot
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        /// <summary>
        /// L'Id utilisé lors de au niveau de l'Identity, Voir section Identity
        /// </summary>
        public string ExternalRoleIdentity { get; set; }
        /// <summary>
        /// Les utilisateurs qui ont ce rôle
        /// </summary>
        public virtual ICollection<User> Users { get; set; }
    }
}