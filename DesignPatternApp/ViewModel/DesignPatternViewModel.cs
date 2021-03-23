using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DesignPatternApp.Model;
using DesignPatternApp.View;

namespace DesignPatternApp.ViewModel
{
    /// <summary>
    /// ViewModel d'un design pattern
    /// <c ref=DesignPatternModel>Utilise le Model DesignPatternModel</c>
    /// </summary>
    public class DesignPatternViewModel : INotifyPropertyChanged, IDpAppLogger
    {
        #region Implémentation INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Survient quand une valeur change
        /// </summary>
        /// <param name="str">Nom de la propriété ayant changé</param>
        public void NotifyPropertyChanged([CallerMemberName] string str = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        #endregion

        #region Liste de DesignPatternModel

        private List<DesignPatternModel> _listeDP;

        public List<DesignPatternModel> ListeDP
        {
            get
            {
                return _listeDP;
            }

            set
            {
                if (value != _listeDP)
                {
                    _listeDP = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region DesignPatternModel courant

        private DesignPatternModel _dpSelectionne;

        public DesignPatternModel DPSelectionne
        {
            get
            {
                return _dpSelectionne;
            }

            set
            {
                if (value != _dpSelectionne)
                {
                    _dpSelectionne = value;
                    NotifyPropertyChanged();
                    this.RapportTraitement = string.Empty;
                }
            }
        }

        #endregion

        #region Rapport de traitement

        private string _rapportTraitement;
        public string RapportTraitement
        {
            get
            {
                return _rapportTraitement;
            }

            set
            {
                if (!string.Equals(value, _rapportTraitement))
                {
                    _rapportTraitement = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Commandes
        public ICommand CmdExecuteDP { get; set; }
        public ICommand CmdShowDpEA { get; set; }

        #endregion

        #region Log 

        /// <summary>
        /// Ajout d'un message dans les logs
        /// </summary>
        /// <param name="message">Message à ajouter</param>
        public void Log(string message)
        {
            this.RapportTraitement += message + Environment.NewLine;
        }

        /// <summary>
        /// Ajout d'une liste de messages dans les logs
        /// </summary>
        /// <param name="messages">Messages à ajouter</param>
        public void Log(List<string> messages)
        {
            this.RapportTraitement += string.Join(Environment.NewLine, messages);
        }

        #endregion

        /// <summary>
        /// Initialisation des données
        /// </summary>
        private void InitialiserDonnees()
        {
            this.ListeDP = LoaderDesignPattern.ObtenirListeDP();
            if (this.ListeDP != null && this.ListeDP.Count > 0)
            {
                this.DPSelectionne = this.ListeDP[0];
            }
        }

        /// <summary>
        /// Exécution de la commande CmdExecuteDP
        /// </summary>
        /// <param name="obj">Paramètre d'exécution de la commande</param>
        public void ExecuteDP(object obj)
        {
            this.RapportTraitement = string.Empty;

            // Exécute le IDPBase associé au DesignPatternModel courant
            this.DPSelectionne.DPImplementation.Execute(this);
        }

        /// <summary>
        /// Exécution de la commande CmdShowDpEA
        /// </summary>
        /// <param name="obj">Paramètre d'exécution de la commande</param>
        public void AfficherDiagrammeEA(object obj)
        {
            DiagrammeEAView diagramme = new DiagrammeEAView();
            diagramme.ShowDiagramme(new DiagrammeEAModel() { ImageEA = this.DPSelectionne.ImageArchi, NomDesignPattern = this.DPSelectionne.Nom });
        }

        /// <summary>
        /// Constructeur du ViewModel
        /// </summary>
        public DesignPatternViewModel()
        {
            // Initialisation des données
            this.InitialiserDonnees();

            // Création de la commande d'exécution
            this.CmdExecuteDP = new DelegateCommand(new Action<object>(this.ExecuteDP));
            this.CmdShowDpEA = new DelegateCommand(new Action<object>(this.AfficherDiagrammeEA));
        }
    }
}
