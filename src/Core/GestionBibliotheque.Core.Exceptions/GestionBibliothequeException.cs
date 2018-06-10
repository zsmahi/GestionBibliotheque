using System;
namespace GestionBibliotheque.Core.Exceptions
{
    /// <summary>
    /// La classe abstraite de toutes les exceptions dans cette application
    /// </summary>
    public abstract class GestionBibliothequeException : Exception
    {
        protected GestionBibliothequeException(): base(){}
        protected GestionBibliothequeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context){}
        protected GestionBibliothequeException(string message) : base(message){}
        protected GestionBibliothequeException(string message, Exception inner) : base(message, inner) {}
    }
}