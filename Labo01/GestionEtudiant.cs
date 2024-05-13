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
    public partial class GestionEtudiant : Form
    {
        public void GetListEtudiant()
        {
            ClLogin Etudiant = new ClLogin();
            MySqlDataReader Rs;
            Rs = Etudiant.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Etudiant.DataSource = dt;

        }

        public GestionEtudiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String xUsername;
            xUsername = textRechercher.Text;

            ClLogin Etudiant = new ClLogin();
            MySqlDataReader Rs;
            Rs = Etudiant.Chercher(xUsername);
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Etudiant.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClLogin gesetud = new ClLogin();
            MySqlDataReader Rs;
            Rs = gesetud.Consulter();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Etudiant.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String xId;
            xId = textId.Text;

            ClLogin gesetud = new ClLogin();
            gesetud.Suppression(xId);
            MessageBox.Show("Suppression effectuer");
            GetListEtudiant();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xNomComplet,xUsername,xPassword, xDateNaissance, xSexe,xEmail,xNiveau,xSpecialite;
            int xMobile;

            xNomComplet = textNomComplet.Text;
            xUsername = textNomUtilisateur.Text;
            xPassword = textPassword.Text;
            xDateNaissance = textDateNaissance.Text;
            xSexe = textSexe.Text;
            xMobile = Convert.ToInt32(textMobile.Text);
            xEmail = textEmail.Text;
            xNiveau = comboBox1.Text;
            xSpecialite = comboBox2.Text;

            if (!string.IsNullOrEmpty(xNomComplet) && xUsername != "" && xPassword != "" && xSexe != "" && xEmail != "" && xNiveau != "" && xSpecialite != "")
            {
                ClLogin gesetud = new ClLogin();
                gesetud.Ajouter(xNomComplet, xUsername, xPassword, xDateNaissance, xSexe, xMobile, xEmail, xNiveau, xSpecialite);
                MessageBox.Show("Bien Ajouter");
                GetListEtudiant();
            }
        }

        private void GestionEtudiant_Load(object sender, EventArgs e)
        {
            GetListEtudiant();
        }
    }
}
