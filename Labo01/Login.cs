using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Labo01
{
    public partial class frmLogin : Form
    {

        int xLoginChecked = 1;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_Connect.ForeColor = Color.DarkRed;
            bt_Exit.ForeColor = Color.DarkRed;
            optEtudiant.Checked = true;
            if (xLoginChecked == 2) optAdmin.Checked = true;
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {

            string Login, Pwd;
            Login = txt_Login.Text;
            Pwd = txt_PWD.Text;
            if(!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Pwd))
            {
                ClLogin login = new ClLogin();

                if (optAdmin.Checked && login.AuthentificationEtudiant(Login, Pwd))
                {
                    MenuPrincipale MenuP = new MenuPrincipale();
                    MenuP.Show();
                }
                else if (optEtudiant.Checked && login.AuthentificationAdmin(Login, Pwd))
                {
                    panel_etudiant pne = new panel_etudiant();
                    pne.Show();
                }
                else
                {
                    MessageBox.Show("Verifier votre login et mot de passe !", "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tapez votre login et mot de passe!","Authentification",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void bt_Connect_MouseHover(object sender, EventArgs e)
        {
            bt_Connect.ForeColor = Color.DarkBlue; 
        }

        private void bt_Connect_MouseLeave(object sender, EventArgs e)
        {
            bt_Connect.ForeColor = Color.DarkRed;
        }

        private void bt_Exit_MouseHover(object sender, EventArgs e)
        {
            bt_Exit.ForeColor = Color.DarkBlue;
        }

        private void bt_Exit_DragLeave(object sender, EventArgs e)
        {
            bt_Exit.ForeColor = Color.DarkRed;
        }
    }
}
