namespace GestionBibliotheque.Core.Entities
{
    /// <summary>
    /// classe abstraite pour encapsuler les personnes (User, Author)
    /// </summary>
    public abstract class Person : BaseEntity
    {
        /// <summary>
        /// Prénom de la personne
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nom de la personne
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Override de la propriété Name ( valeur retourné = @FirstName + @LastName)
        /// </summary>
        public override string Name { get { return string.Concat(FirstName,"",LastName); }}        
    }
}