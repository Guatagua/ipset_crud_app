using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Labo01
{
    
    public partial class Specialite : Form
    {
        public void GetListSpecialite()
        {
            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Specialite.DataSource = dt;

        }
        public Specialite()
        {
            InitializeComponent();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
           
                string xCode, xSpecialite;
                xCode = txt_Code.Text;
                xSpecialite = txt_Specialite.Text;
                if (!string.IsNullOrEmpty(xCode)  && xSpecialite != "")
                {
                ClSpecialite Spt = new ClSpecialite(); 
                Spt.Ajouter(xCode,xSpecialite);
                GetListSpecialite();
                }
               
            }

        private void Form2_Load(object sender, EventArgs e)
        {

            GetListSpecialite();

        }

        private void List_Specialite_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetListSpecialite();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String xCode;
            xCode = txt_Code.Text;

            ClSpecialite Spt = new ClSpecialite();
            MySqlDataReader Rs;
            Rs = Spt.Consulter(xCode);
            DataTable dt = new DataTable();
            dt.Load(Rs);
            List_Specialite.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String xCode;
            xCode = txt_Code.Text;

            ClSpecialite Spt = new ClSpecialite();
            Spt.Suppression(xCode);
            GetListSpecialite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string xCode, xSpecialite;
            xCode = txt_Code.Text;
            xSpecialite = txt_Specialite.Text;

            ClSpecialite Spt = new ClSpecialite();
            Spt.Modifier(xCode, xSpecialite);
            GetListSpecialite();
        }
    }
}
