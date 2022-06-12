using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Space_Invaders.Stockage
{   
    /// <summary>
    /// Classe pour gérer les sauvegardes et le chargement
    /// </summary>
    /// <author>Soufiane EZZMENAY</author>
    public class Storage
    {   
        /// <summary>
        /// Permet de sauvegarder un objet sur un fichier
        /// </summary>
        /// <param name="fichier">le nom de fichier</param>
        /// <param name="objet">l'objet</param>
        /// <author>Soufiane EZZMENAY</author>
        public static void Sauve(string fichier, Object objet)
        {
            //Verifier si le fichier existe
            if (File.Exists(fichier))
            {
                // le supprimer
                File.Delete(fichier);
            }
            // création du flux pour l'écriture dans le fichier
            FileStream flux = new FileStream(fichier, FileMode.Create);
            // création d'un objet pour le formatage en binaire des informations
            BinaryFormatter fbinaire = new BinaryFormatter();
            // sérialisation des objets de la collection
            fbinaire.Serialize(flux, objet);
            // fermeture du flux
            flux.Close();
        }

        /// <summary>
        /// Permet de charger le contenu d'un fichier et le transformer en objet
        /// </summary>
        /// <param name="fichier">nom du fichier</param>
        /// <returns>objet</returns>
        /// <author>Soufiane EZZMENAY</author>
        public static Object Recup(string fichier)
        {
            // Verifier de l'existance du fichier
            if (File.Exists(fichier))
            {
                // ouverture du flux pour la lecture dans le fichier
                FileStream flux = new FileStream(fichier, FileMode.Open);
                // création d'un objet pour le formatage en binaire des informations
                BinaryFormatter fbinaire = new BinaryFormatter();
                // récupération de l'objet sérialisé
                try
                {
                    Object objet = fbinaire.Deserialize(flux);
                    // fermeture du flux
                    flux.Close();
                    // retour de l'objet
                    return objet;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
