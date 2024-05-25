using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Labo01
{
    public partial class Matieres : Form
    {
        public Matieres()
        {
            InitializeComponent();
        }
        public void GetListMatiere()
        {
            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Matiere.DataSource = dt;

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            string Codematiere, Matiere;
            Codematiere = txt_Code_matiere.Text;
            Matiere = txt_Matiere.Text;
            if (!string.IsNullOrEmpty(Codematiere) && Matiere != "")
            {
                ClMatiere Spt = new ClMatiere();
                Spt.Ajouter(Codematiere, Matiere);
                GetListMatiere();
            }
        }
    

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetListMatiere();
        }

        private void Matieres_Load(object sender, EventArgs e)
        {
            GetListMatiere();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Codematiere;
            Codematiere = txt_Code_matiere.Text;

            ClMatiere Spt = new ClMatiere();
            Spt.Suppression(Codematiere);
            GetListMatiere();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Codematiere, Matiere;
            Codematiere = txt_Code_matiere.Text;
            Matiere = txt_Matiere.Text;

            ClMatiere Spt = new ClMatiere();
            Spt.Modifier(Codematiere, Matiere);
            GetListMatiere();
        }
    }
}
