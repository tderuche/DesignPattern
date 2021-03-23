using DesignPatternApp;

namespace DPCore.Adapter
{
    /// <summary>
    /// Implémentation du design pattern "Adapter"
    /// </summary>
    public class DPAdapter : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public override void Execute()
        {
            Personne personne = new Personne();
            AdapterPersonne adapterPersonne = new AdapterPersonne(personne);

            this.AfficherNomEtPrenom(adapterPersonne);
            this.AfficherNomEtPrenom(new Utilisateur("Michael-Jordan"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <returns>Le rapport de traitement</returns>
        private void AfficherNomEtPrenom(IUtilisateur utilisateur)
        {
            this._logger.Log(utilisateur.ObtenirPrenomEtNom());
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPAdapter(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
