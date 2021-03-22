using System;
using DesignPatternApp;

namespace DPCore.Builder
{
    /// <summary>
    /// Cuisinier italien
    /// </summary>
    class CuisinierItalien : ICuisinier
    {
        private readonly IDpAppLogger _logger;

        /// <summary>
        /// Préparation de la viande italienne
        /// </summary>
        public void PreparerViande()
        {
            this._logger.Log("Viande italienne préparée !");
        }

        /// <summary>
        /// Préparation des légumes italiens
        /// </summary>
        public void PreparerLegumes()
        {
            this._logger.Log("Légumes italiens préparés !");
        }

        /// <summary>
        /// Préparation de la sauce italienne
        /// </summary>
        public void PreparerSauce()
        {
            this._logger.Log("Sauce italienne préparée !");
        }

        /// <summary>
        /// Obtention du plat une fois terminé
        /// </summary>
        public void ObtenirPlatComplet()
        {
            this._logger.Log("Les pâtes carbonara sont prêtes !");
        }

        /// <summary>
        /// Obtention du nom du cuisiner
        /// </summary>
        public string ObtenirNom()
        {
            return "cuisinier italien";
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public CuisinierItalien(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
