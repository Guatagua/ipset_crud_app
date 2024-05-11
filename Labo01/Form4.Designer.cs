namespace Labo01
{
    partial class frm_MenuPrincipale
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
            this.bt_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_Etudiant
            // 
            this.bt_Etudiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Etudiant.Location = new System.Drawing.Point(12, 23);
            this.bt_Etudiant.Name = "bt_Etudiant";
            this.bt_Etudiant.Size = new System.Drawing.Size(130, 50);
            this.bt_Etudiant.TabIndex = 0;
            this.bt_Etudiant.Text = "Etudiant";
            this.bt_Etudiant.UseVisualStyleBackColor = true;
            this.bt_Etudiant.Click += new System.EventHandler(this.bt_Etudiant_Click);
            // 
            // bt_Specialite
            // 
            this.bt_Specialite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Specialite.Location = new System.Drawing.Point(148, 23);
            this.bt_Specialite.Name = "bt_Specialite";
            this.bt_Specialite.Size = new System.Drawing.Size(132, 50);
            this.bt_Specialite.TabIndex = 1;
            this.bt_Specialite.Text = "Specialité";
            this.bt_Specialite.UseVisualStyleBackColor = true;
            this.bt_Specialite.Click += new System.EventHandler(this.bt_Specialite_Click);
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exit.Location = new System.Drawing.Point(551, 23);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(119, 50);
            this.bt_Exit.TabIndex = 2;
            this.bt_Exit.Text = "Quitter";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // frm_MenuPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 497);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_Specialite);
            this.Controls.Add(this.bt_Etudiant);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MenuPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Etudiant;
        private System.Windows.Forms.Button bt_Specialite;
        private System.Windows.Forms.Button bt_Exit;
    }
}