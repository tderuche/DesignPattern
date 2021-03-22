using System;
using DesignPatternApp;

namespace DPCore.Singleton
{
    /// <summary>
    /// Gestion de l'accès à une Database par un Singleton
    /// </summary>
    public class Database
    {
        /// <summary>
        /// Instance static privée
        /// </summary>
        private static Database dataBase;

        private static IDpAppLogger _logger;

        /// <summary>
        /// Méthode static publique permettant d'obtenir un Database
        /// </summary>
        /// <param name="listeTraitementAppelant">Rapport de traitement pour l'appelant</param>
        public static Database GetDatabase(IDpAppLogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));

            _logger.Log("L'obtention de l'instance Database a été demandée");

            // Instancie le Database si besoin
            if (dataBase == null)
            {
                dataBase = new Database();
                _logger.Log("L'instance Database a été créée");
            }

            return dataBase;
        }

        /// <summary>
        /// Exécution d'une requête sur la Database
        /// </summary>
        /// <param name="requete">Requête à exécuter</param>
        public void ExecuterRequete(string requete)
        {
            _logger.Log(string.Format("La requête [{0}] a été exécutée", requete));
        }
    }
}
