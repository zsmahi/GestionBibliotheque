using System.Threading.Tasks;
namespace GestionBibliotheque.Core.Interfaces
{
    /// <summary>
    /// Interface du service d'envoi de mail
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Méthode d'envoie de mails
        /// </summary>
        /// <param name="email">l'adresse du destinataire</param>
        /// <param name="subject">l'objet du mail</param>
        /// <param name="message">le contenu du mail envoyé</param>
        /// <returns>Task void</returns>
        Task SendEmailAsync(string email, string subject, string message);
    }
}