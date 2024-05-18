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
using Org.BouncyCastle.Crypto.Agreement.JPake;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Labo01
{
    public partial class GestionEtudiant : Form
    {

        int xSexeChecked = 1;
        string imageLocation = "";

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
            string xNomComplet,xUsername,xPassword, xSexe, xMobile,xEmail,xNiveau,xSpecialite;
            DateTime xDateNaissance;

            xNomComplet = textNomComplet.Text;
            xUsername = textNomUtilisateur.Text;
            xPassword = textPassword.Text;
            xMobile = textMobile.Text;
            xEmail = textEmail.Text;
            xNiveau = comboBox1.Text;
            xSpecialite = comboBox2.Text;
            xDateNaissance = dateTimePicker1.Value;

            if (optHomme.Checked) xSexe = "Homme";
            else xSexe = "Femme";

            if (!string.IsNullOrEmpty(xNomComplet) && xUsername != "" && xPassword != "" && xMobile != ""  && xEmail != "" && xNiveau != "" && xSpecialite != "")
            {
                ClLogin gesetud = new ClLogin();
                gesetud.Ajouter(xNomComplet, xUsername, xPassword, xDateNaissance.ToShortDateString(), xSexe, xMobile, xEmail, xNiveau, xSpecialite);
                MessageBox.Show("Bien Ajouter");
                GetListEtudiant();
            }
        }

        private void GestionEtudiant_Load(object sender, EventArgs e)
        {
            GetListEtudiant();

            Load_tbl_Specialite_in_combobox();

            optHomme.Checked = true;
                if (xSexeChecked == 2) optFemme.Checked = true;
               
        }

        public void Load_tbl_Specialite_in_combobox()
        {
            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Lister_code_specialite();
            DataTable dt = new DataTable();
            dt.Columns.Add("code", typeof(string));
            dt.Load(Rs);
            comboBox2.ValueMember = "code";
            comboBox2.DataSource = dt;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_Browser_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageLocation = dialog.FileName.ToString();
                Box_Picture.ImageLocation = imageLocation;
            }
        }
    }
}
