using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo01
{
    public partial class MenuPrincipale : Form
    {
        public MenuPrincipale()
        {
            InitializeComponent();
        }
        public void loadformmenuprincipale(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void bt_Specialite_Click(object sender, EventArgs e)
        {
            loadformmenuprincipale(new frmSpecialite());
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void bt_Etudiant_Click(object sender, EventArgs e)
        {
            loadformmenuprincipale(new GestionEtudiant());
        }

        private void bt_Groupe_Click(object sender, EventArgs e)
        {
            loadformmenuprincipale(new frmGroupe());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadformmenuprincipale(new Traiter());
        }

        private void bt_Matiere_Click(object sender, EventArgs e)
        {
            loadformmenuprincipale(new Matieres());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
