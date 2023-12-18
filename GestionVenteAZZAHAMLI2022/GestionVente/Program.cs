using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace GestionVente
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Produit p1 = new Produit("10001","Souris",45,20);
            Produit p2 = new Produit("10002", "Ordinateur", 5,1000);
            Produit p3 = new Produit("10003", "PC", 25,100);
            Produit.LesProduits.Add(p1);
            Produit.LesProduits.Add(p2);
            Produit.LesProduits.Add(p3);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GestionProduit());
            
        }
    }
}
