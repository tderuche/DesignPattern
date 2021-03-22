namespace DPCore.AbstractFactory
{
    // Each Concrete Factory has a corresponding product variant.
    class RenaultFactory : IConstructeurFactory
    {
        /// <summary>
        /// Construction d'un SUV
        /// </summary>
        /// <returns>le SUV Renault Kadjar</returns>
        public ISUV ConstruireSUV()
        {
            return new RenaultKadjar();
        }

        /// <summary>
        /// Construction d'une citadine
        /// </summary>
        /// <returns>La citadine Renault Twingo</returns>
        public ICitadine ConstruireCitadine()
        {
            return new RenaultTwingo();
        }

        /// <summary>
        /// Nom du constructeur
        /// </summary>
        /// <returns>Le nom du constructeur Renault</returns>
        public string ObtenirNom()
        {
            return "Renault";
        }
    }
}
