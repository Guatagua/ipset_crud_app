namespace Labo01
{
    partial class MenuPrincipale
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
            this.bt_Etudiant = new System.Windows.Forms.Button();
            this.bt_Specialite = new System.Windows.Forms.Button();
            this.bt_Groupe = new System.Windows.Forms.Button();
            this.bt_Matiere = new System.Windows.Forms.Button();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Etudiant
            // 
            this.bt_Etudiant.Location = new System.Drawing.Point(25, 12);
            this.bt_Etudiant.Name = "bt_Etudiant";
            this.bt_Etudiant.Size = new System.Drawing.Size(75, 23);
            this.bt_Etudiant.TabIndex = 0;
            this.bt_Etudiant.Text = "Etudiant";
            this.bt_Etudiant.UseVisualStyleBackColor = true;
            this.bt_Etudiant.Click += new System.EventHandler(this.bt_Etudiant_Click);
            // 
            // bt_Specialite
            // 
            this.bt_Specialite.Location = new System.Drawing.Point(106, 12);
            this.bt_Specialite.Name = "bt_Specialite";
            this.bt_Specialite.Size = new System.Drawing.Size(75, 23);
            this.bt_Specialite.TabIndex = 1;
            this.bt_Specialite.Text = "Specialite";
            this.bt_Specialite.UseVisualStyleBackColor = true;
            this.bt_Specialite.Click += new System.EventHandler(this.bt_Specialite_Click);
            // 
            // bt_Groupe
            // 
            this.bt_Groupe.Location = new System.Drawing.Point(187, 12);
            this.bt_Groupe.Name = "bt_Groupe";
            this.bt_Groupe.Size = new System.Drawing.Size(75, 23);
            this.bt_Groupe.TabIndex = 2;
            this.bt_Groupe.Text = "Groupe";
            this.bt_Groupe.UseVisualStyleBackColor = true;
            this.bt_Groupe.Click += new System.EventHandler(this.bt_Groupe_Click);
            // 
            // bt_Matiere
            // 
            this.bt_Matiere.Location = new System.Drawing.Point(268, 12);
            this.bt_Matiere.Name = "bt_Matiere";
            this.bt_Matiere.Size = new System.Drawing.Size(75, 23);
            this.bt_Matiere.TabIndex = 3;
            this.bt_Matiere.Text = "Matière";
            this.bt_Matiere.UseVisualStyleBackColor = true;
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(349, 12);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 23);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // MenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 533);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Matiere);
            this.Controls.Add(this.bt_Groupe);
            this.Controls.Add(this.bt_Specialite);
            this.Controls.Add(this.bt_Etudiant);
            this.Name = "MenuPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Etudiant;
        private System.Windows.Forms.Button bt_Specialite;
        private System.Windows.Forms.Button bt_Groupe;
        private System.Windows.Forms.Button bt_Matiere;
        private System.Windows.Forms.Button bt_Exit;
    }
}