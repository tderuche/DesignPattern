namespace DPCore.Adapter
{
    /// <summary>
    /// Représente un Utilisateur
    /// Implémentation d'un IUtilisateur
    /// </summary>
    class Utilisateur : IUtilisateur
    {
        /// <summary>
        /// Nom et prénom de l'utilisateur
        /// </summary>
        private readonly string _prenomNom;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="prenomNom">Nom et prénom de l'utilisateur</param>
        public Utilisateur(string prenomNom)
        {
            this._prenomNom = prenomNom;
        }

        /// <summary>
        /// Métode issue de IUtilisateur
        /// Retourne le prénom suivi du nom de l'utilisateur
        /// </summary>
        /// <returns>Le nom suivi du prénom</returns>
        public string ObtenirPrenomEtNom()
        {
            return string.Format("Utilisateur: {0}", this._prenomNom);
        }
    }
}
