using DesignPatternApp;

namespace DPCore.Proxy
{
    /// <summary>
    /// Implémentation du design pattern "Proxy"
    /// </summary>
    public class DPProxy : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public void Execute(IDpAppLogger logger)
        {
            InternetProxy internet = new InternetProxy(logger);
            internet.Connect("google.fr");
            internet.Connect("siteX.com");
            internet.Connect("isagri.fr");
        }
    }
}
