using System.Collections.Generic;
using System.Threading.Tasks;
namespace GestionBibliotheque.Core.Interfaces
{
    /// <summary>
    /// Un répos générique async pour l'interrogation de la base de données
    /// </summary>
    /// <typeparam name="T">Entité en question</typeparam>
    public interface IRepositoryAsync<T> where T : class
    {
        /// <summary>
        /// Récupere en mode asynchrone l'instance qui a comme ID "id"
        /// </summary>
        /// <param name="id"> le id de l'entité recherchée</param>
        /// <returns>l'entité en question</returns>
        Task<T> GetByIdAsync(int id);
        /// <summary>
        /// Récupere en mode asynchrone l'instance qui a comme spécification "spec"
        /// </summary>
        /// <param name="spec">les spécifications de filtre</param>
        /// <returns>l'entité en question</returns>
        Task<T> GetSingleBySpecAsync(ISpecification<T> spec);
        /// <summary>
        /// Récuperer tous les enregistrements en mode asynchrone
        /// </summary>
        /// <returns>Liste des enregistrements de l'entité</returns>
        Task<List<T>> ListAllAsync();
        /// <summary>
        /// Récuperer en mode asynchrone tous les enregistrements qui matches avec une spécification spec
        /// </summary>
        /// <param name="spec">les spécifications de filtre</param>
        /// <returns>les enregistrements qui matchent</returns>
        Task<List<T>> ListAsync(ISpecification<T> spec);
        /// <summary>
        /// Ajouter en mode asynchrone un enregistrement de l'entité en question
        /// </summary>
        /// <param name="entity">l'enregistrement à ajouter</param>
        Task AddAsync(T entity);
        /// <summary>
        /// Mettre à jour en mode asynchrone un enregistrement dans la base de données
        /// </summary>
        /// <param name="entity">l'enregistrement à mettre à jour</param>
        Task UpdateAsync(T entity);
        /// <summary>
        /// Supprimer en mode asynchrone un enregistrement de la base de données
        /// </summary>
        /// <param name="entity">l'enregistrement à supprimer</param>
        Task DeleteAsync(T entity);
    }
}