namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// Paramètrage de l'application
    /// </summary>
    public class Settings : BaseEntity
    {
        /// <summary>
        /// l'Année en cours
        /// </summary>
        public string CurrentYear { get; set; }
        /// <summary>
        /// Prefixe du Code Utilisateur
        /// </summary>
        public string UserCodePrefix { get; set; }
        /// <summary>
        /// Suffixe du Code Utilisateur
        /// </summary>
        public string UserCodeSuffix { get; set; }
        /// <summary>
        /// Prefixe du Code Role
        /// </summary>
        public string RoleCodePrefix { get; set; }
        /// <summary>
        /// Suffixe du Code Role
        /// </summary>
        public string RoleCodeSuffix { get; set; }
        /// <summary>
        /// Prefixe du Code Livre
        /// </summary>
        public string BookCodePrefix { get; set; }
        /// <summary>
        /// Suffixe du Code Livre
        /// </summary>
        public string BookCodeSuffix { get; set; }
        /// <summary>
        /// Prefixe du Code de la Categorie du Livre
        /// </summary>
        public string CategoryCodePrefix { get; set; }
        /// <summary>
        /// Suffixe du Code de la Categorie du Livre
        /// </summary>
        public string CategoryCodeSuffix { get; set; }
        /// <summary>
        /// Prefixe du Code de l'auteur
        /// </summary>
        public string AuthorCodePrefix { get; set; }
        /// <summary>
        /// Suffixe du Code l'auteur
        /// </summary>
        public string AuthorCodeSuffix { get; set; }
        /// <summary>
        /// Durée d'emprunt de livre
        /// </summary>
        public int NumberOfDaysForBorrowingABook { get; set; }
        /// <summary>
        /// Nombre de retards autorisés
        /// </summary>
        public int NumberOfAllowedLate { get; set; }
    }
}