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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Etudiant
            // 
            this.bt_Etudiant.Location = new System.Drawing.Point(53, 62);
            this.bt_Etudiant.Name = "bt_Etudiant";
            this.bt_Etudiant.Size = new System.Drawing.Size(75, 23);
            this.bt_Etudiant.TabIndex = 0;
            this.bt_Etudiant.Text = "Etudiant";
            this.bt_Etudiant.UseVisualStyleBackColor = true;
            this.bt_Etudiant.Click += new System.EventHandler(this.bt_Etudiant_Click);
            // 
            // bt_Specialite
            // 
            this.bt_Specialite.Location = new System.Drawing.Point(53, 134);
            this.bt_Specialite.Name = "bt_Specialite";
            this.bt_Specialite.Size = new System.Drawing.Size(75, 23);
            this.bt_Specialite.TabIndex = 1;
            this.bt_Specialite.Text = "Specialite";
            this.bt_Specialite.UseVisualStyleBackColor = true;
            this.bt_Specialite.Click += new System.EventHandler(this.bt_Specialite_Click);
            // 
            // bt_Groupe
            // 
            this.bt_Groupe.Location = new System.Drawing.Point(53, 202);
            this.bt_Groupe.Name = "bt_Groupe";
            this.bt_Groupe.Size = new System.Drawing.Size(75, 23);
            this.bt_Groupe.TabIndex = 2;
            this.bt_Groupe.Text = "Groupe";
            this.bt_Groupe.UseVisualStyleBackColor = true;
            this.bt_Groupe.Click += new System.EventHandler(this.bt_Groupe_Click);
            // 
            // bt_Matiere
            // 
            this.bt_Matiere.Location = new System.Drawing.Point(53, 272);
            this.bt_Matiere.Name = "bt_Matiere";
            this.bt_Matiere.Size = new System.Drawing.Size(75, 23);
            this.bt_Matiere.TabIndex = 3;
            this.bt_Matiere.Text = "Matière";
            this.bt_Matiere.UseVisualStyleBackColor = true;
            this.bt_Matiere.Click += new System.EventHandler(this.bt_Matiere_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(53, 451);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(75, 23);
            this.bt_Exit.TabIndex = 4;
            this.bt_Exit.Text = "Exit";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Traiter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.bt_Etudiant);
            this.panel1.Controls.Add(this.bt_Specialite);
            this.panel1.Controls.Add(this.bt_Groupe);
            this.panel1.Controls.Add(this.bt_Exit);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.bt_Matiere);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 6;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(200, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(950, 30);
            this.panelheader.TabIndex = 7;
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(950, 550);
            this.mainpanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(924, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principale";
            this.panel1.ResumeLayout(false);
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Etudiant;
        private System.Windows.Forms.Button bt_Specialite;
        private System.Windows.Forms.Button bt_Groupe;
        private System.Windows.Forms.Button bt_Matiere;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Label label1;
    }
}