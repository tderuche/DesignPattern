using DesignPatternApp;

namespace DPCore.Proxy
{
    /// <summary>
    /// Implémentation du design pattern "Proxy"
    /// </summary>
    public class DPProxy : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public override void Execute()
        {
            InternetProxy internet = new InternetProxy(this._logger);
            internet.Connect("google.fr");
            internet.Connect("siteX.com");
            internet.Connect("isagri.fr");
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPProxy(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
