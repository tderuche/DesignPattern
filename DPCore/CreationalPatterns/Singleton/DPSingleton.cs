using DesignPatternApp;

namespace DPCore.Singleton
{
    /// <summary>
    /// Implémentation du design pattern "Singleton"
    /// </summary>
    public class DPSingleton : IDPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public void Execute(IDpAppLogger logger)
        {
            Database db1 = Database.GetDatabase(logger);
            db1.ExecuterRequete("SELECT Champ FROM Table");

            Database db2 = Database.GetDatabase(logger);
            db2.ExecuterRequete("INSERT INTO Table (Champ) VALUES (Valeur)");
        }
    }
}
