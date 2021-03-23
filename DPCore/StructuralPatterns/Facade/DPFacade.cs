using DesignPatternApp;

namespace DPCore.StructuralPatterns.Facade
{
    /// <summary>
    /// Implémentation du design pattern "Facade"
    /// </summary>
    public class DPFacade : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public override void Execute()
        {
            FormeCreateur formeCreateur = new FormeCreateur(this._logger);
            formeCreateur.DessinerCercle();
            formeCreateur.DessinerRectangle();
            formeCreateur.DessinerCercle();
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPFacade(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
