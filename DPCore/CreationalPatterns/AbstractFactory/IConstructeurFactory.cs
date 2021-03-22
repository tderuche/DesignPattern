namespace DPCore.AbstractFactory
{
    /// <summary>
    /// Interface des constructeurs de voitures
    /// </summary>
    public interface IConstructeurFactory
    {
        /// <summary>
        /// Construction d'un SUV
        /// </summary>
        /// <returns>Le SUV</returns>
        ISUV ConstruireSUV();

        /// <summary>
        /// Construction d'une citadine
        /// </summary>
        /// <returns>La citadine</returns>
        ICitadine ConstruireCitadine();

        /// <summary>
        /// Nom du constructeur
        /// </summary>
        /// <returns>Le nom du constructeur</returns>
        string ObtenirNom();
    }
}
