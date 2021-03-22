using DesignPatternApp;

namespace DPCore.Singleton
{
    /// <summary>
    /// Implémentation du design pattern "Singleton"
    /// </summary>
    public class DPSingleton : DPBase
    {
        /// <summary>
        /// Execution du traitement
        /// </summary>
        /// <returns>Le rapport de traitement</returns>
        public override void Execute()
        {
            Database db1 = Database.GetDatabase(this._logger);
            db1.ExecuterRequete("SELECT Champ FROM Table");

            Database db2 = Database.GetDatabase(this._logger);
            db2.ExecuterRequete("INSERT INTO Table (Champ) VALUES (Valeur)");
        }

        /// <summary>
        /// Constructeur pour la gestion des logs
        /// </summary>
        /// <param name="logger">Gestionnaire de logs</param>
        public DPSingleton(IDpAppLogger logger) : base(logger)
        {

        }
    }
}
