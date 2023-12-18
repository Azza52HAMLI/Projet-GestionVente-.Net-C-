namespace GestionVente
{
    partial class GestionProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpProduit = new System.Windows.Forms.GroupBox();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lstProduit = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNbreTotal = new System.Windows.Forms.TextBox();
            this.lblNbreTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.grpProduit.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProduit
            // 
            this.grpProduit.BackColor = System.Drawing.Color.Silver;
            this.grpProduit.Controls.Add(this.txtPrixAchat);
            this.grpProduit.Controls.Add(this.label2);
            this.grpProduit.Controls.Add(this.txtQuantite);
            this.grpProduit.Controls.Add(this.txtDesignation);
            this.grpProduit.Controls.Add(this.txtRef);
            this.grpProduit.Controls.Add(this.lblQuantite);
            this.grpProduit.Controls.Add(this.lblDesignation);
            this.grpProduit.Controls.Add(this.lblReference);
            this.grpProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpProduit.Location = new System.Drawing.Point(37, 36);
            this.grpProduit.Name = "grpProduit";
            this.grpProduit.Size = new System.Drawing.Size(310, 202);
            this.grpProduit.TabIndex = 0;
            this.grpProduit.TabStop = false;
            this.grpProduit.Text = "Caractéristiques d\'un produit";
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(139, 162);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.Size = new System.Drawing.Size(151, 26);
            this.txtPrixAchat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix d\'achat";
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(139, 125);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(151, 26);
            this.txtQuantite.TabIndex = 5;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(139, 87);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(151, 26);
            this.txtDesignation.TabIndex = 4;
            // 
            // txtRef
            // 
            this.txtRef.Location = new System.Drawing.Point(139, 51);
            this.txtRef.MaxLength = 5;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(152, 26);
            this.txtRef.TabIndex = 3;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.Location = new System.Drawing.Point(20, 129);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(70, 20);
            this.lblQuantite.TabIndex = 2;
            this.lblQuantite.Text = "Quantité";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(20, 90);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(94, 20);
            this.lblDesignation.TabIndex = 1;
            this.lblDesignation.Text = "Désignation";
            // 
            // lblReference
            // 
            this.lblReference.AutoSize = true;
            this.lblReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReference.Location = new System.Drawing.Point(20, 51);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(84, 20);
            this.lblReference.TabIndex = 0;
            this.lblReference.Text = "Référence";
            // 
            // lstProduit
            // 
            this.lstProduit.FormattingEnabled = true;
            this.lstProduit.Location = new System.Drawing.Point(379, 57);
            this.lstProduit.Name = "lstProduit";
            this.lstProduit.Size = new System.Drawing.Size(267, 121);
            this.lstProduit.Sorted = true;
            this.lstProduit.TabIndex = 1;
            this.lstProduit.SelectedIndexChanged += new System.EventHandler(this.lstProduit_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFermer);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Location = new System.Drawing.Point(42, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 53);
            this.panel1.TabIndex = 2;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(333, 12);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(122, 29);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Enabled = false;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(207, 12);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(115, 30);
            this.btnModifier.TabIndex = 1;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(78, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(115, 30);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtNbreTotal);
            this.panel2.Controls.Add(this.lblNbreTotal);
            this.panel2.Location = new System.Drawing.Point(380, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 47);
            this.panel2.TabIndex = 3;
            // 
            // txtNbreTotal
            // 
            this.txtNbreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbreTotal.Location = new System.Drawing.Point(189, 10);
            this.txtNbreTotal.Name = "txtNbreTotal";
            this.txtNbreTotal.Size = new System.Drawing.Size(63, 26);
            this.txtNbreTotal.TabIndex = 1;
            this.txtNbreTotal.Text = "0";
            // 
            // lblNbreTotal
            // 
            this.lblNbreTotal.AutoSize = true;
            this.lblNbreTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbreTotal.ForeColor = System.Drawing.Color.DarkRed;
            this.lblNbreTotal.Location = new System.Drawing.Point(14, 13);
            this.lblNbreTotal.Name = "lblNbreTotal";
            this.lblNbreTotal.Size = new System.Drawing.Size(166, 20);
            this.lblNbreTotal.TabIndex = 0;
            this.lblNbreTotal.Text = "Nombre de produits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Les produits";
            // 
            // btnFermer
            // 
            this.btnFermer.Enabled = false;
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(468, 12);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(122, 29);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // GestionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstProduit);
            this.Controls.Add(this.grpProduit);
            this.Name = "GestionProduit";
            this.Text = "Gestion Produit";
            this.Load += new System.EventHandler(this.GestionProduit_Load);
            this.grpProduit.ResumeLayout(false);
            this.grpProduit.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProduit;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.ListBox lstProduit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNbreTotal;
        private System.Windows.Forms.Label lblNbreTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFermer;
    }
}