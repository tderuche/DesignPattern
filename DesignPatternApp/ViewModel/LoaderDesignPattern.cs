using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using DesignPatternApp.Model;
using DPCore.AbstractFactory;
using DPCore.Adapter;
using DPCore.Builder;
using DPCore.FactoryMethod;
using DPCore.Proxy;
using DPCore.Singleton;
using DPCore.StructuralPatterns.Facade;

namespace DesignPatternApp.ViewModel
{
    /// <summary>
    /// Classe de chargement des différents design patterns
    /// </summary>
    public static class LoaderDesignPattern
    {
        #region Chargement interne

        /// <summary>
        /// Création du DPAbstractFactory
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPAbstractFactory()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPAbstractFactory));
            dp.DPImplementation = new DPAbstractFactory();

            return dp;
        }

        /// <summary>
        /// Création du DPAdapter
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPAdapter()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPAdapter));
            dp.DPImplementation = new DPAdapter();

            return dp;
        }

        /// <summary>
        /// Création du DPBuilder
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPBuilder()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPBuilder));
            dp.DPImplementation = new DPBuilder();

            return dp;
        }

        /// <summary>
        /// Création du DPFactoryMethod
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPFactoryMethod()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPFactoryMethod));
            dp.DPImplementation = new DPFactoryMethod();

            return dp;
        }

        /// <summary>
        /// Création du DPSingleton
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPSingleton()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPSingleton));
            dp.DPImplementation = new DPSingleton();

            return dp;
        }

        /// <summary>
        /// Création du DPProxy
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPProxy()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPProxy));
            dp.DPImplementation = new DPProxy();

            return dp;
        }

        /// <summary>
        /// Création du DPAdapter
        /// </summary>
        /// <returns></returns>
        private static DesignPatternModel ObtenirDPFacade()
        {
            DesignPatternModel dp = ObtenirDP(nameof(DPFacade));
            dp.DPImplementation = new DPFacade();

            return dp;
        }

        /// <summary>
        /// Obtient la description d'un DesignPatternModel
        /// </summary>
        /// <param name="typeIDPBase">Le type de la classe d'une implémentation d'un IDPBase</param>
        /// <returns>Le DesignPatternModel souhaité</returns>
        private static DesignPatternModel ObtenirDP(string resourceName)
        {
            return new DesignPatternModel()
            {
                Nom = Resources.NomDP.ResourceManager.GetString(resourceName),
                Description = Resources.DescriptionDP.ResourceManager.GetString(resourceName),
                Image = new BitmapImage(new Uri(string.Format("..\\Resources\\Pictures\\Logos\\{0}.png", resourceName), UriKind.Relative)),
                ImageArchi = new BitmapImage(new Uri(string.Format("..\\Resources\\Pictures\\EA\\{0}.png", resourceName), UriKind.Relative)),
                MainArticle = Resources.LinkMainArticle.ResourceManager.GetString(resourceName),
                UsageCSharp = Resources.LinkUsageCSharp.ResourceManager.GetString(resourceName),
                ExempleCSharp = Resources.LinkExempleCSharp.ResourceManager.GetString(resourceName)
            };
        }

        #endregion

        /// <summary>
        /// Obtient la liste des Design Patterns
        /// </summary>
        /// <returns></returns>
        public static List<DesignPatternModel> ObtenirListeDP()
        {
            List<DesignPatternModel> listeDP = new List<DesignPatternModel>
            {
                ObtenirDPAbstractFactory(),
                ObtenirDPAdapter(),
                ObtenirDPBuilder(),
                ObtenirDPFactoryMethod(),
                ObtenirDPSingleton(),
                ObtenirDPProxy(),
                ObtenirDPFacade()
            };

            return listeDP;
        }
    }
}
