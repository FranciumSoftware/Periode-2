@echo off
setlocal enabledelayedexpansion

REM Demander à l'utilisateur de spécifier le dossier à indexer
set /p dossier="Veuillez entrer le chemin du dossier à indexer : "

REM Vérifier si le dossier existe
if not exist "%dossier%" (
    echo Le dossier spécifié n'existe pas.
    exit /b 1
)

REM Créer un fichier pour enregistrer l'index
set fichier_index=%dossier%\index.txt

REM Initialiser le fichier d'index
echo Index des fichiers dans le dossier "%dossier%" > "%fichier_index%"
echo ========================================= >> "%fichier_index%"

REM Parcourir récursivement le dossier et lister les noms des fichiers
for /r "%dossier%" %%f in (*) do (
    echo %%~nxf >> "%fichier_index%"
)

echo L'indexation est terminée. La liste des fichiers a été enregistrée dans %fichier_index%.
pause
