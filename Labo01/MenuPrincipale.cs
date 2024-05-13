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

        private void bt_Specialite_Click(object sender, EventArgs e)
        {
            frmSpecialite frmSpecialite = new frmSpecialite();
            frmSpecialite.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void bt_Etudiant_Click(object sender, EventArgs e)
        {
            GestionEtudiant gesetud = new GestionEtudiant();
            gesetud.Show();
        }
    }
}
