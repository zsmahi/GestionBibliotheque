namespace GestionBibliotheque.Core.Interfaces
{
    /// <summary>
    /// La journalisation de nos évènements
    /// </summary>
    /// <typeparam name="T">T : entité en question</typeparam>
    public interface Ilogger<T> where T : class
    {
        /// <summary>
        /// Les informations ( insertion , mise à jour , suppression )
        /// </summary>
        /// <param name="message">le message à enregistrer</param>
        /// <param name="args">d'autres paramètres</param>
        void Information(string message, params object[] args);
        /// <summary>
        /// Les warning affichées
        /// </summary>
        /// <param name="message">le message à enregistrer</param>
        /// <param name="args">d'autres paramètres</param>
        void Warning(string message, params object[] args);
        /// <summary>
        /// Les erreurs métiers affichées
        /// </summary>
        /// <param name="message">le message à enregistrer</param>
        /// <param name="args">d'autres paramètres</param>
        void Error(string message, params object[] args);
        /// <summary>
        /// Les exceptions affichées
        /// </summary>
        /// <param name="message">le message à enregistrer</param>
        /// <param name="args">d'autres paramètres</param>
        void Fatal(string message, params object[] args);
        /// <summary>
        /// Le mode debug
        /// </summary>
        /// <param name="message">le message à enregistrer</param>
        /// <param name="args">d'autres paramètres</param>
        void Debug(string message, params object[] args);
    }
}