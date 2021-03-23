using DesignPatternApp;

namespace DPCore.Adapter
{
    /// <summary>
    /// Implémentation du design pattern "Adapter"
    /// </summary>
    public class DPAdapter : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public void Execute(IDpAppLogger logger)
        {
            Personne personne = new Personne();
            AdapterPersonne adapterPersonne = new AdapterPersonne(personne);

            this.AfficherNomEtPrenom(adapterPersonne, logger);
            this.AfficherNomEtPrenom(new Utilisateur("Michael-Jordan"), logger);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <returns>Le rapport de traitement</returns>
        private void AfficherNomEtPrenom(IUtilisateur utilisateur, IDpAppLogger logger)
        {
            logger.Log(utilisateur.ObtenirPrenomEtNom());
        }
    }
}
