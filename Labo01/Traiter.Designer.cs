namespace Labo01
{
    partial class Traiter
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
            this.traiter_list = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_champ_etat = new System.Windows.Forms.TextBox();
            this.txt_id_sup = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_id_etat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.traiter_list)).BeginInit();
            this.SuspendLayout();
            // 
            // traiter_list
            // 
            this.traiter_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.traiter_list.Location = new System.Drawing.Point(12, 184);
            this.traiter_list.Name = "traiter_list";
            this.traiter_list.Size = new System.Drawing.Size(696, 254);
            this.traiter_list.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier l\'état avec Id";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_champ_etat
            // 
            this.txt_champ_etat.Location = new System.Drawing.Point(452, 100);
            this.txt_champ_etat.Name = "txt_champ_etat";
            this.txt_champ_etat.Size = new System.Drawing.Size(146, 20);
            this.txt_champ_etat.TabIndex = 3;
            // 
            // txt_id_sup
            // 
            this.txt_id_sup.Location = new System.Drawing.Point(48, 100);
            this.txt_id_sup.Name = "txt_id_sup";
            this.txt_id_sup.Size = new System.Drawing.Size(131, 20);
            this.txt_id_sup.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Suppression avec Id";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_id_etat
            // 
            this.txt_id_etat.Location = new System.Drawing.Point(662, 41);
            this.txt_id_etat.Name = "txt_id_etat";
            this.txt_id_etat.Size = new System.Drawing.Size(46, 20);
            this.txt_id_etat.TabIndex = 6;
            // 
            // Traiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.txt_id_etat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_id_sup);
            this.Controls.Add(this.txt_champ_etat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.traiter_list);
            this.Name = "Traiter";
            this.Text = "Traiter";
            this.Load += new System.EventHandler(this.Traiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.traiter_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView traiter_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_champ_etat;
        private System.Windows.Forms.TextBox txt_id_sup;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_id_etat;
    }
}