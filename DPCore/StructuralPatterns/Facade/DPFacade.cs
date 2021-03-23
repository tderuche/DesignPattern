using DesignPatternApp;

namespace DPCore.StructuralPatterns.Facade
{
    /// <summary>
    /// Implémentation du design pattern "Facade"
    /// </summary>
    public class DPFacade : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public void Execute(IDpAppLogger logger)
        {
            FormeCreateur formeCreateur = new FormeCreateur(logger);
            formeCreateur.DessinerCercle();
            formeCreateur.DessinerRectangle();
            formeCreateur.DessinerCercle();
        }
    }
}
