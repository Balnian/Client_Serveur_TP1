﻿namespace TP1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BT_Chiffrer = new System.Windows.Forms.Button();
            this.BT_Dechiffrer = new System.Windows.Forms.Button();
            this.RB_Rotation = new System.Windows.Forms.RadioButton();
            this.RB_Circulaire = new System.Windows.Forms.RadioButton();
            this.RB_OuEx = new System.Windows.Forms.RadioButton();
            this.TB_Avant = new System.Windows.Forms.TextBox();
            this.TB_Apres = new System.Windows.Forms.TextBox();
            this.NmUPDOWN = new System.Windows.Forms.NumericUpDown();
            this.LB_Avant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NmUPDOWN)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Chiffrer
            // 
            this.BT_Chiffrer.Location = new System.Drawing.Point(75, 214);
            this.BT_Chiffrer.Name = "BT_Chiffrer";
            this.BT_Chiffrer.Size = new System.Drawing.Size(75, 23);
            this.BT_Chiffrer.TabIndex = 0;
            this.BT_Chiffrer.Text = "Chiffrer";
            this.BT_Chiffrer.UseVisualStyleBackColor = true;
            this.BT_Chiffrer.Click += new System.EventHandler(this.BT_Chiffrer_Click);
            // 
            // BT_Dechiffrer
            // 
            this.BT_Dechiffrer.Location = new System.Drawing.Point(189, 214);
            this.BT_Dechiffrer.Name = "BT_Dechiffrer";
            this.BT_Dechiffrer.Size = new System.Drawing.Size(75, 23);
            this.BT_Dechiffrer.TabIndex = 1;
            this.BT_Dechiffrer.Text = "Déchiffrer";
            this.BT_Dechiffrer.UseVisualStyleBackColor = true;
            this.BT_Dechiffrer.Click += new System.EventHandler(this.BT_Dechiffrer_Click);
            // 
            // RB_Rotation
            // 
            this.RB_Rotation.AutoSize = true;
            this.RB_Rotation.Location = new System.Drawing.Point(122, 32);
            this.RB_Rotation.Name = "RB_Rotation";
            this.RB_Rotation.Size = new System.Drawing.Size(65, 17);
            this.RB_Rotation.TabIndex = 2;
            this.RB_Rotation.TabStop = true;
            this.RB_Rotation.Text = "Rotation";
            this.RB_Rotation.UseVisualStyleBackColor = true;
            // 
            // RB_Circulaire
            // 
            this.RB_Circulaire.AutoSize = true;
            this.RB_Circulaire.Location = new System.Drawing.Point(122, 69);
            this.RB_Circulaire.Name = "RB_Circulaire";
            this.RB_Circulaire.Size = new System.Drawing.Size(68, 17);
            this.RB_Circulaire.TabIndex = 3;
            this.RB_Circulaire.TabStop = true;
            this.RB_Circulaire.Text = "Circulaire";
            this.RB_Circulaire.UseVisualStyleBackColor = true;
            // 
            // RB_OuEx
            // 
            this.RB_OuEx.AutoSize = true;
            this.RB_OuEx.Location = new System.Drawing.Point(122, 103);
            this.RB_OuEx.Name = "RB_OuEx";
            this.RB_OuEx.Size = new System.Drawing.Size(78, 17);
            this.RB_OuEx.TabIndex = 4;
            this.RB_OuEx.TabStop = true;
            this.RB_OuEx.Text = "Ou Exclusif";
            this.RB_OuEx.UseVisualStyleBackColor = true;
            // 
            // TB_Avant
            // 
            this.TB_Avant.Location = new System.Drawing.Point(64, 155);
            this.TB_Avant.Name = "TB_Avant";
            this.TB_Avant.Size = new System.Drawing.Size(100, 20);
            this.TB_Avant.TabIndex = 5;
            // 
            // TB_Apres
            // 
            this.TB_Apres.Location = new System.Drawing.Point(180, 155);
            this.TB_Apres.Name = "TB_Apres";
            this.TB_Apres.Size = new System.Drawing.Size(106, 20);
            this.TB_Apres.TabIndex = 6;
            // 
            // NmUPDOWN
            // 
            this.NmUPDOWN.Location = new System.Drawing.Point(12, 156);
            this.NmUPDOWN.Name = "NmUPDOWN";
            this.NmUPDOWN.Size = new System.Drawing.Size(31, 20);
            this.NmUPDOWN.TabIndex = 7;
            // 
            // LB_Avant
            // 
            this.LB_Avant.AutoSize = true;
            this.LB_Avant.Location = new System.Drawing.Point(85, 135);
            this.LB_Avant.Name = "LB_Avant";
            this.LB_Avant.Size = new System.Drawing.Size(35, 13);
            this.LB_Avant.TabIndex = 8;
            this.LB_Avant.Text = "Avant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Après";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 325);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Avant);
            this.Controls.Add(this.NmUPDOWN);
            this.Controls.Add(this.TB_Apres);
            this.Controls.Add(this.TB_Avant);
            this.Controls.Add(this.RB_OuEx);
            this.Controls.Add(this.RB_Circulaire);
            this.Controls.Add(this.RB_Rotation);
            this.Controls.Add(this.BT_Dechiffrer);
            this.Controls.Add(this.BT_Chiffrer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NmUPDOWN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Chiffrer;
        private System.Windows.Forms.Button BT_Dechiffrer;
        private System.Windows.Forms.RadioButton RB_Rotation;
        private System.Windows.Forms.RadioButton RB_Circulaire;
        private System.Windows.Forms.RadioButton RB_OuEx;
        private System.Windows.Forms.TextBox TB_Avant;
        private System.Windows.Forms.TextBox TB_Apres;
        private System.Windows.Forms.NumericUpDown NmUPDOWN;
        private System.Windows.Forms.Label LB_Avant;
        private System.Windows.Forms.Label label2;
    }
}

