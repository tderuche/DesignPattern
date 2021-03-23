using System;
using DesignPatternApp;

namespace DPCore.Proxy
{
    /// <summary>
    /// Classe de connection à Internet
    /// </summary>
    public class Internet : IInternet
    {
        private readonly IDpAppLogger _logger;

        /// <summary>
        /// Méthode pour se connecter à un serveur
        /// </summary>
        /// <param name="server">Nom du serveur Internet</param>
        /// <returns>Résultat de la connection</returns>
        public void Connect(string server)
        {
            this._logger.Log("Connection à " + server);
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public Internet(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
