using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{  
    public class Produit
    {String reference, designation;
     int quantite;
        double prixAchat;
        static List<Produit> lesProduits = new List<Produit>();

        public Produit(String reference, String designation, int quantite, double prixAchat)
        {
            this.reference = reference;
            this.designation = designation;
            this.quantite = quantite;
            this.prixAchat = prixAchat;
        }
        public static List<Produit> LesProduits
        {
            get { return lesProduits; }
            set { lesProduits = value; }
        }

        public string Reference { get => reference; set => reference = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double PrixAchat { get => prixAchat; set => prixAchat = value; }

        public int GetQuantite()
        {
            return quantite;
         }
       
        public String GetReference()
        {return reference;   }
        public String GetDesignation()
        { return designation; }
        public double GetPrixAchat()
        { return prixAchat;  }
        public override String ToString()
        {
            return reference + " | "+designation +" | "+ quantite+ " | " + prixAchat;
        }

        //il faut redéfinir la méthode Equals car on a besoin 
        //pour les collections de List, de ListBox et ComboBox
        //surtout pour la appeler la méthode Remove LesProduits.Remove(p)
        public override bool Equals(object obj)
        {
            if(obj!=null && obj is Produit)
            {
                Produit p = (Produit)obj;
                if (this.reference.Equals(p.reference))
                    return true;
                else
                    return false;

            }
            return false;
        }
    }
}
