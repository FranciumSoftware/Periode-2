import os
import requests
from zipfile import ZipFile

def download_images_from_txt(txt_file_path, output_zip_path):
    # Lire les URLs depuis le fichier texte
    with open(txt_file_path, 'r') as file:
        urls = file.readlines()

    # Créer un dossier temporaire pour stocker les images téléchargées
    temp_dir = 'C:/Users/romai/Documents/Developper/C#/Periode 2/Periode 2/Resources/temp_images'
    os.makedirs(temp_dir, exist_ok=True)

    # En-tête User-Agent pour se conformer à la politique de Wikimedia
    headers = {
        'User-Agent': 'RoNard38 (romain.bernard38@yahoo.com)'
    }

    # Télécharger chaque image et la sauvegarder dans le dossier temporaire
    for i, url in enumerate(urls):
        url = url.strip()  # Supprimer les espaces et les sauts de ligne
        try:
            response = requests.get(url, headers=headers)
            response.raise_for_status()  # Vérifier si la requête a réussi
            # Sauvegarder l'image dans le dossier temporaire
            image_path = os.path.join(temp_dir, f'image_{i+1}.jpg')
            with open(image_path, 'wb') as img_file:
                img_file.write(response.content)
        except Exception as e:
            print(f"Erreur lors du téléchargement de {url}: {e}")

    # Créer un fichier ZIP contenant toutes les images téléchargées
    with ZipFile(output_zip_path, 'w') as zipf:
        for root, _, files in os.walk(temp_dir):
            for file in files:
                file_path = os.path.join(root, file)
                zipf.write(file_path, os.path.basename(file_path))

    # Supprimer le dossier temporaire et son contenu
    for root, dirs, files in os.walk(temp_dir, topdown=False):
        for name in files:
            os.remove(os.path.join(root, name))
        for name in dirs:
            os.rmdir(os.path.join(root, name))
    os.rmdir(temp_dir)

# Exemple d'utilisation
download_images_from_txt('C:/Users/romai/Documents/Developper/C#/Periode 2/Periode 2/Resources/image.txt', 'C:/Users/romai/Documents/Developper/C#/Periode 2/Periode 2/Resources/images.zip')
