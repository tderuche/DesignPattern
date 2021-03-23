using System;
using System.Collections.Generic;
using DesignPatternApp;

namespace DPCore.Proxy
{
    /// <summary>
    /// Proxy de connection à Internet
    /// </summary>
    public class InternetProxy : IInternet
    {
        private readonly Internet _internet;
        private readonly List<string> _bannedSites;

        private readonly IDpAppLogger _logger;

        /// <summary>
        /// Constructeur du Proxy
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public InternetProxy(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            this._internet = new Internet(this._logger);

            // Initialise les sites bannis
            this._bannedSites = new List<string>
            {
                "siteX.com"
            };
        }

        /// <summary>
        /// Méthode pour se connecter à un serveur
        /// </summary>
        /// <param name="server">Nom du serveur Internet</param>
        /// <returns>Résultat de la connection</returns>
        public void Connect(string server)
        {
            if (!this.CheckAccess(server))
            {
                this._logger.Log("Accès refusé à " + server);
            }
            else
            {
                this._internet.Connect(server);
            }
        }

        /// <summary>
        /// Vérifie si l'accès au serveur est autorisé
        /// </summary>
        /// <param name="server">Serveur dont il faut vérifier l'accès</param>
        /// <returns>True si accès autorisé</returns>
        private bool CheckAccess(string server)
        {
            return !this._bannedSites.Contains(server);
        }
    }
}
