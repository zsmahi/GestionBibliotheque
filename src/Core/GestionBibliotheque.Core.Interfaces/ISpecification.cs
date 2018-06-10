using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace GestionBibliotheque.Core.Interfaces
{
    /// <summary>
    /// Interface de specification de recherche dans la base de données
    /// </summary>
    /// <typeparam name="T">Entité en question</typeparam>
    public interface ISpecification<T>
    {
        /// <summary>
        /// Les criteres de filtrage
        /// </summary>
        Expression<Func<T, bool>> Criteria { get; }
        /// <summary>
        /// liste des inclusions (lazy loading)
        /// </summary>
        List<Expression<Func<T, object>>> Includes { get; }
        /// <summary>
        /// Inclusion en format string
        /// </summary>
        List<string> IncludeStrings { get; }
    }
}