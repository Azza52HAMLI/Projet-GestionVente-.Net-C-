using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;
namespace GestionVente
{
    public partial class GestionProduit : Form
    {
        public GestionProduit()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtRef.Text.Length == 0)
                MessageBox.Show("il faut donner une référence");
            else
                  if (txtDesignation.TextLength == 0)
                MessageBox.Show("Donner Designation ");
            else
                if (txtQuantite.Text.Equals(""))
                MessageBox.Show("Donner quantité ");
            else
            {
                String reference = txtRef.Text;
                String designation = txtDesignation.Text;
                try  //pour controler si quantité et prix sont des nombres 
                {
                    int quant = Convert.ToInt32(txtQuantite.Text);
                    double prix = Convert.ToDouble(txtPrixAchat.Text);
                       //Créer le produit 
                    Produit p1 = new Produit(reference, designation, quant, prix);
                    //si le produit existe déjà, on informe l'utilisateur 

                    if (Produit.LesProduits.Contains(p1) == true)//si le produit n'existe pas 
                    {
                        MessageBox.Show("Le produit existe déjà");
                    }
                    else {
                        //l'ajouter produit dans dans la Liste static
                        Produit.LesProduits.Add(p1 );
                        //Actualiser l'interface graphique
                        lstProduit.Items.Add(p1);
                        txtNbreTotal.Text = Produit.LesProduits.Count.ToString();
                    }
                    ViderChamps();
                }
                catch (FormatException excep)
                {

                    MessageBox.Show("Verifier les types de données doivent être numérique", "Attention");
                }

            }

        }

        //Ajouter une méthode pour vider les champs après chaque traitement
        public void ViderChamps()
        {
            txtRef.Text = "";
            txtDesignation.Clear();
            txtPrixAchat.Text = "0";
            txtQuantite.Text = "0";
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;
            btnAjouter.Enabled = true;
            txtRef.Enabled = true;
        }

        private void GestionProduit_Load(object sender, EventArgs e)
        {
                lstProduit.Items.AddRange(Produit.LesProduits.ToArray());
            txtNbreTotal.Text = Produit.LesProduits.Count.ToString();
        }

        private void lstProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProduit.SelectedIndex != -1)
            {
                btnModifier.Enabled = true;
                btnSupprimer.Enabled = true;
                btnAjouter.Enabled = false;
                Produit p = (Produit)lstProduit.SelectedItem;
                txtRef.Text = p.GetReference();
                txtRef.Enabled = false; //pour ne pas changer la référence du produit 
                txtDesignation.Text = p.GetDesignation();
                txtQuantite.Text = p.GetQuantite().ToString();
                txtPrixAchat.Text = p.GetPrixAchat().ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            String reference = txtRef.Text;
            String designation = txtDesignation.Text;
            bool existe = false;
            try
            {
                int quant = Convert.ToInt32(txtQuantite.Text);
                double prix = Convert.ToDouble(txtPrixAchat.Text);


                
                    DialogResult reponse = MessageBox.Show("Voulez vous modifier ce produit", "Attention", MessageBoxButtons.YesNo);
                    if (reponse == DialogResult.Yes)
                    {
                    Produit prodSup = (Produit)lstProduit.SelectedItem;
                    lstProduit.Items.Remove(prodSup); //la méthode Equals est obligatoire dans la claase Produit
                    Produit.LesProduits.Remove(prodSup);//Remove d'une liste supprime en utilisant Equals 
                    Produit p1 = new Produit(reference, designation, quant, prix);

                    Produit.LesProduits.Add(p1);
                    lstProduit.Items.Add(p1);
                    ViderChamps();

                    }
                
            }
            catch (FormatException excep)
            {

                MessageBox.Show("Verifier les types de données doivent être numérique", "Attention");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstProduit.SelectedIndex != -1)
            {
                Produit p = (Produit)lstProduit.SelectedItem;
            //c'est obligatoire : Avant chaque suppression il faut vérifier avec l'utilisateur
                DialogResult reponse = MessageBox.Show("Voulez vous supprimer le produit \n" + p, "Attention Pour la suppression", MessageBoxButtons.YesNo);
                if (reponse == DialogResult.Yes)
                {
                       lstProduit.Items.Remove(p); //elle fait le parcours et utilise la méthode Equals du Produit
                       Produit.LesProduits.Remove(p);
                            txtNbreTotal.Text = Produit.LesProduits.Count.ToString();
                            ViderChamps();
                   
                }
            }
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Voulez vous fermer l'application" , "Attention Pour la suppression", MessageBoxButtons.YesNo);
            if (reponse == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}