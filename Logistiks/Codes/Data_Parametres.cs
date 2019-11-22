using System;
using System.Collections.Generic;
using System.Linq;

namespace Logistiks.Codes
{
    public partial class Data_Parametres
    {
        private string nom_user;        
        private string mot_de_passe_user;
        private string nom_serveur;
        private string nom_base_de_donnees;
        private string niveau_acces;

        public string Nom_user
        {
            get
            {
                return nom_user;
            }

            set
            {
                nom_user = value;
            }
        }
        public string Mot_de_passe_user
        {
            get
            {
                return mot_de_passe_user;
            }

            set
            {
                mot_de_passe_user = value;
            }
        }

        public string Nom_serveur
        {
            get
            {
                return nom_serveur;
            }

            set
            {
                nom_serveur = value;
            }
        }
        public string Nom_base_de_donnees
        {
            get
            {
                return nom_base_de_donnees;
            }

            set
            {
                nom_base_de_donnees = value;
            }
        }
        public string Niveau_acces
        {
            get
            {
                return niveau_acces;
            }

            set
            {
                niveau_acces = value;
            }
        }
        public override string ToString()
        {            
            return
                string.Format
                (
                    "Data Source ={0};Initial Catalog={1};User ID={2};Password= {3};",
                    nom_serveur, nom_base_de_donnees, nom_user, mot_de_passe_user
                );
    }
    }
}
