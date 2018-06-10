using System;
namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// la classe mère de toutes les entités
    /// Il ne s'agit que du métier SI en cours ( gestion de bibliothèque )
    /// Des frameworks ont été mis en place pour Authentification / Autorisation, Logging 
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Constructeur. les Propriétés sont initialisées à vide ici
        /// </summary>
        protected BaseEntity()
        {
            Code = Name = Description = string.Empty;
            CreationDateTime = UpdateDateTime = DateTime.Now;
        }
        /// <summary>
        /// ID de l'entité
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Le Code métier de l'entité
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Le nom de l'entité:
        /// s'il s'agit d'un utilisateur cette propriété retourne ( nom + prenom )
        /// mais elle n'est pas mappée au niveau de la base de données
        /// </summary>
        public virtual string Name { get; set; }
        /// <summary>
        /// La description de l'entité en cours
        /// Il s'agit d'un champ de saisie libre
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// La date/heure de creation de l'objet en cours
        /// </summary>
        public DateTime CreationDateTime { get; set; }
        /// <summary>
        /// La date/heure de mise à jour
        /// </summary>
        public DateTime UpdateDateTime { get; set; }
        /// <summary>
        /// L'objet est validé ou pas (voir section role)
        /// </summary>
        public bool IsActif { get; set; }
    }
}