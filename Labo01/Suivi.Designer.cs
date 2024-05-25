namespace Labo01
{
    partial class Suivie
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.suivie_demande = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.suivie_demande)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "suivie par mobile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(449, 65);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(123, 20);
            this.txt_mobile.TabIndex = 1;
            // 
            // suivie_demande
            // 
            this.suivie_demande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suivie_demande.Location = new System.Drawing.Point(12, 207);
            this.suivie_demande.Name = "suivie_demande";
            this.suivie_demande.Size = new System.Drawing.Size(695, 263);
            this.suivie_demande.TabIndex = 3;
            // 
            // Suivie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.suivie_demande);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.button1);
            this.Name = "Suivie";
            this.Text = "Suivie";
            this.Load += new System.EventHandler(this.Suivie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suivie_demande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.DataGridView suivie_demande;
    }
}