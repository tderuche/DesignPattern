using System;
using DesignPatternApp;

namespace DPCore.Builder
{
    /// <summary>
    /// Cuisinier français
    /// </summary>
    public class CuisinierFrancais : ICuisinier
    {
        private readonly IDpAppLogger _logger;

        /// <summary>
        /// Préparation de la viande française
        /// </summary>
        public void PreparerViande()
        {
            this._logger.Log("Viande française préparée !");
        }

        /// <summary>
        /// Préparation des légumes français
        /// </summary>
        public void PreparerLegumes()
        {
            this._logger.Log("Légumes français préparés !");
        }

        /// <summary>
        /// Préparation de la sauce française
        /// </summary>
        public void PreparerSauce()
        {
            this._logger.Log("Sauce française préparée !");
        }

        /// <summary>
        /// Obtention du nom du cuisiner
        /// </summary>
        public string ObtenirNom()
        {
            return "cuisinier français";
        }

        /// <summary>
        /// Obtention du plat une fois terminé
        /// </summary>
        public void ObtenirPlatComplet()
        {
            this._logger.Log("Le boeuf bourguignon est prêt !");
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public CuisinierFrancais(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
    }
}
