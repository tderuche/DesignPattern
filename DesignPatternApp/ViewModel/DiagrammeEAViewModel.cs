using System.ComponentModel;
using System.Runtime.CompilerServices;
using DesignPatternApp.Model;

namespace DesignPatternApp.ViewModel
{
    /// <summary>
    /// ViewModel pour afficher le diagramme EA d'un Design Pattern
    /// </summary>
    public class DiagrammeEAViewModel : INotifyPropertyChanged
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

        #region Model

        private DiagrammeEAModel _model;

        public DiagrammeEAModel Model
        {
            get
            {
                return _model;
            }

            set
            {
                if (value != _model)
                {
                    _model = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion

        #region Titre fenêtre

        private string _titre;

        public string Titre
        {
            get
            {
                _titre = string.Format("Architecture du Design Pattern {0}", this.Model.NomDesignPattern);
                return _titre;
            }

            set
            {
                if (!string.Equals(value, _titre))
                {
                    _titre = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion
    }
}
