using System;
using System.Collections.Generic;
using System.Resources;
using System.Windows; // Pour MessageBox

namespace Periode_2
{
    internal class DataElements
    {
        public static int IndexEl = 1;

        // Déclaration des listes
        public static List<string> ElementNumber;
        public static List<string> elementImage;
        public static List<string> elementMasse;
        public static List<string> elementDecouverte;
        public static List<string> elementAnnee;
        public static List<string> elementAbreviation;
        public static List<string> elementGroupe;
        public static List<string> elementPeriode;

        // Constructeur statique pour initialiser les listes
        static DataElements()
        {
            try
            {
                var resourceManager = new ResourceManager("Periode_2.Properties.Resources", typeof(DataElements).Assembly);

                ElementNumber = LoadResourceString(resourceManager, "liste");
                elementImage = LoadResourceString(resourceManager, "image");
                elementMasse = LoadResourceString(resourceManager, "masse");
                elementDecouverte = LoadResourceString(resourceManager, "decouverte");
                elementAnnee = LoadResourceString(resourceManager, "annee");
                elementAbreviation = LoadResourceString(resourceManager, "Abbr");
                elementGroupe = LoadResourceString(resourceManager, "Groupe");
                elementPeriode = LoadResourceString(resourceManager, "Periode");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'initialisation des données : {ex.Message}");
            }
        }

        // Méthode pour lire une ressource string depuis les ressources
        private static List<string> LoadResourceString(ResourceManager resourceManager, string resourceName)
        {
            try
            {
                var resourceString = resourceManager.GetObject(resourceName) as string;
                if (resourceString != null)
                {
                    return new List<string>(resourceString.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries));
                }
                else
                {
                    throw new Exception($"La ressource '{resourceName}' n'a pas été trouvée ou n'est pas une chaîne de caractères.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la lecture de la ressource '{resourceName}': {ex.Message}");
                return new List<string>();
            }
        }
    }
}
