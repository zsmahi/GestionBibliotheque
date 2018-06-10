using System.Collections.Generic;
namespace GestionBibliotheque.Core.Interfaces
{
    /// <summary>
    /// Un répos générique pour l'interrogation de la base de données
    /// </summary>
    /// <typeparam name="T">Entité en question</typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Récupere l'instance qui a comme ID "id"
        /// </summary>
        /// <param name="id"> le id de l'entité recherchée</param>
        /// <returns>l'entité en question</returns>
        T GetById(int id);
        /// <summary>
        /// Récupere l'instance qui a comme spécification "spec"
        /// </summary>
        /// <param name="spec">les spécifications de filtre</param>
        /// <returns>l'entité en question</returns>
        T GetSingleBySpec(ISpecification<T> spec);
        /// <summary>
        /// Récuperer tous les enregistrements
        /// </summary>
        /// <returns>Liste des enregistrements de l'entité</returns>
        IEnumerable<T> ListAll();
        /// <summary>
        /// Récuperer tous les enregistrements qui matches avec une spécification spec
        /// </summary>
        /// <param name="spec">les spécifications de filtre</param>
        /// <returns>les enregistrements qui matchent</returns>
        IEnumerable<T> List(ISpecification<T> spec);
        /// <summary>
        /// Ajouter un enregistrement de l'entité en question
        /// </summary>
        /// <param name="entity">l'enregistrement à ajouter</param>
        void Add(T entity);
        /// <summary>
        /// Mettre à jour un enregistrement dans la base de données
        /// </summary>
        /// <param name="entity">l'enregistrement à mettre à jour</param>
        void Update(T entity);
        /// <summary>
        /// Supprimer un enregistrement de la base de données
        /// </summary>
        /// <param name="entity">l'enregistrement à supprimer</param>
        void Delete(T entity);
    }
}