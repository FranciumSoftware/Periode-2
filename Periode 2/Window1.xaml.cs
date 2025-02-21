using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Periode_2
{
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            int affIndexEl = DataElements.IndexEl + 1;
            string IndexEl = affIndexEl.ToString();

            // Affichage des informations
            Abbreviation.Text = DataElements.elementAbreviation[DataElements.IndexEl];
            Nom.Text = DataElements.ElementNumber[DataElements.IndexEl];
            Masse.Text = DataElements.elementMasse[DataElements.IndexEl];
            Decouvreur.Text = DataElements.elementDecouverte[DataElements.IndexEl];
            Date.Text = DataElements.elementAnnee[DataElements.IndexEl];
            Groupe.Text = DataElements.elementGroupe[DataElements.IndexEl];
            Periode.Text = DataElements.elementPeriode[DataElements.IndexEl];

            try
            {
                Uri uriSource = new Uri("https://franciumsoftware.github.io/images/image_" + IndexEl + ".jpg");

                // Chargez l'image en tant que BitmapImage
                BitmapImage bitmapImage = new BitmapImage(uriSource);

                // Affectez l'image à la source de votre contrôle Image
                myImage.Source = bitmapImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
            }

            this.Deactivated += Details_Deactivated;
        }

        private void Details_Deactivated(object sender, System.EventArgs e)
        {
            // Fermer la fenêtre lorsqu'elle n'est plus active
            this.Close();
        }
    }
}
