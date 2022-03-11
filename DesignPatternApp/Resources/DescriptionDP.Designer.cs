﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesignPatternApp.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DescriptionDP {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DescriptionDP() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DesignPatternApp.Resources.DescriptionDP", typeof(DescriptionDP).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de créer des familles d’objets apparentés sans préciser leur classe concrète..
        /// </summary>
        internal static string DPAbstractFactory {
            get {
                return ResourceManager.GetString("DPAbstractFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de faire collaborer des objets ayant des interfaces normalement incompatibles..
        /// </summary>
        internal static string DPAdapter {
            get {
                return ResourceManager.GetString("DPAdapter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de construire des objets complexes étape par étape. Ce patron permet de construire différentes variations ou représentations d’un objet en utilisant le même code de construction..
        /// </summary>
        internal static string DPBuilder {
            get {
                return ResourceManager.GetString("DPBuilder", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de faire circuler une demande dans une chaîne de handlers. Lorsqu&apos;un handler reçoit une demande, il décide de la traiter ou de l’envoyer au handler suivant de la chaîne..
        /// </summary>
        internal static string DPChainOfResponsibility {
            get {
                return ResourceManager.GetString("DPChainOfResponsibility", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet d&apos;agencer les objets dans des arborescences afin de pouvoir traiter celles-ci comme des objets individuels..
        /// </summary>
        internal static string DPComposite {
            get {
                return ResourceManager.GetString("DPComposite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Procure une interface qui offre un accès simplifié à une librairie, un framework ou à n’importe quel ensemble complexe de classes..
        /// </summary>
        internal static string DPFacade {
            get {
                return ResourceManager.GetString("DPFacade", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Définit une interface pour la création d’objets dans une classe mère, mais délègue aux sous-classes le choix des types d’objets à créer..
        /// </summary>
        internal static string DPFactoryMethod {
            get {
                return ResourceManager.GetString("DPFactoryMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de diminuer les dépendances chaotiques entre les objets. Ce patron restreint les communications directes entre les objets et les force à collaborer uniquement via un objet médiateur..
        /// </summary>
        internal static string DPMediator {
            get {
                return ResourceManager.GetString("DPMediator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de fournir un substitut d’un objet. Une procuration donne le contrôle sur l’objet original, vous permettant d’effectuer des manipulations avant ou après que la demande ne lui parvienne..
        /// </summary>
        internal static string DPProxy {
            get {
                return ResourceManager.GetString("DPProxy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permet de garantir que l’instance d’une classe n’existe qu’en un seul exemplaire, tout en fournissant un point d’accès global à cette instance..
        /// </summary>
        internal static string DPSingleton {
            get {
                return ResourceManager.GetString("DPSingleton", resourceCulture);
            }
        }
    }
}
