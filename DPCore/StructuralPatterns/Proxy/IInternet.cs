namespace DPCore.Proxy
{
    /// <summary>
    /// Interface de connection à Internet
    /// </summary>
    interface IInternet
    {
        /// <summary>
        /// Méthode pour se connecter à un serveur
        /// </summary>
        /// <param name="server">Nom du serveur Internet</param>
        void Connect(string server);
    }
}
