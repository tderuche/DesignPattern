namespace DPCore.Adapter
{
    /// <summary>
    /// Adaptateur permettant d'utiliser une Personne en tant que IUtilisateur
    /// </summary>
    class AdapterPersonne : IUtilisateur
    {
        /// <summary>
        /// Référence sur la Personne
        /// </summary>
        private readonly Personne _personnne;

        /// <summary>
        /// Constructeur de l'adaptateur
        /// </summary>
        /// <param name="personnne"></param>
        public AdapterPersonne(Personne personnne)
        {
            this._personnne = personnne;
        }

        /// <summary>
        /// Métode issue de IUtilisateur
        /// Retourne le prénom suivi du nom de l'utilisateur
        /// </summary>
        /// <returns>Le nom suivi du prénom</returns>
        public string ObtenirPrenomEtNom()
        {
            return string.Format("Adaptateur: {0}-{1}", _personnne.ObtenirPrenom, _personnne.ObtenirNom);
        }
    }
}
