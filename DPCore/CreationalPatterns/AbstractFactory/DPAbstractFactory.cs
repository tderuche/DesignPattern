using DesignPatternApp;

namespace DPCore.AbstractFactory
{
    /// <summary>
    /// Implémentation du design pattern "Abstract Factory"
    /// </summary>
    public class DPAbstractFactory : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public override void Execute()
        {
            // Demande à l'usine Peugeot de créer des voitures
            TraitementAbstractFactory.ConstruireVoitures(new PeugeotFactory(), this._logger);

            // Demande à l'usine Renault de créer des voitures
            TraitementAbstractFactory.ConstruireVoitures(new RenaultFactory(), this._logger);
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPAbstractFactory(IDpAppLogger logger) : base(logger)
        {

        }
    }

    /// <summary>
    /// Traitement réalisé sur une factory
    /// </summary>
    static class TraitementAbstractFactory
    {
        /// <summary>
        /// Construit les voitures et ce peu importe le constructeur
        /// </summary>
        /// <param name="factory">Le constructeur de voiture</param>
        /// <returns>Le rapport de traitement</returns>
        public static void ConstruireVoitures(IConstructeurFactory factory, IDpAppLogger logger)
        {
            // Création d'un SUV
            ISUV suv = factory.ConstruireSUV();

            // Création d'une citadine
            ICitadine citadine = factory.ConstruireCitadine();

            logger.Log(string.Format("Constructeur {0}", factory.ObtenirNom()));
            logger.Log(string.Format("Ce SUV {0} coûte {1}", suv.ObtenirNomVoiture(), suv.ObtenirPrix()));
            logger.Log(string.Format("Cette citadine {0} coûte {1}", citadine.ObtenirNomVoiture(), citadine.ObtenirPrix()));
        }
    }
}
