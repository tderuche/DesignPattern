using System.Collections.Generic;

namespace DesignPatternApp
{
    /// <summary>
    /// Interface pour logger les rapports de traitement des Design Patterns
    /// </summary>
    public interface IDpAppLogger
    {
        /// <summary>
        /// Ajout d'un message dans les logs
        /// </summary>
        /// <param name="message">Message à ajouter</param>
        void Log(string message);

        /// <summary>
        /// Ajout d'une liste de messages dans les logs
        /// </summary>
        /// <param name="messages">Messages à ajouter</param>
        void Log(List<string> messages);
    }
}
