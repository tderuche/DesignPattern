namespace DPCore.AbstractFactory
{
    // Concrete Factories produce a family of products that belong to a single
    // variant. The factory guarantees that resulting products are compatible.
    // Note that signatures of the Concrete Factory's methods return an abstract
    // product, while inside the method a concrete product is instantiated.
    public class PeugeotFactory : IConstructeurFactory
    {
        /// <summary>
        /// Construction d'un SUV
        /// </summary>
        /// <returns>le SUV Peugeot 3008</returns>
        public ISUV ConstruireSUV()
        {
            return new Peugeot3008();
        }

        /// <summary>
        /// Construction d'une citadine
        /// </summary>
        /// <returns>La citadine Peugeot 208</returns>
        public ICitadine ConstruireCitadine()
        {
            return new Peugeot208();
        }

        /// <summary>
        /// Nom du constructeur
        /// </summary>
        /// <returns>Le nom du constructeur Peugeot</returns>
        public string ObtenirNom()
        {
            return "Peugeot";
        }
    }
}
