using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Labo01
{
    
    public partial class Form2 : Form
    {
        OleDbConnection cns = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Razek\OneDrive\Documents\Cours\C Sharp\Labos\Labo01\Labo01\data\dbipset.accdb");
        public void GetListSpecialite()
        {
            ClSpecialite Spt = new ClSpecialite();
            OleDbDataAdapter Rs = new OleDbDataAdapter();
            Rs = Spt.Lister();
            DataTable dt = new DataTable();
            Rs.Fill(dt);
            List_Specialite.DataSource = dt;

        }
        public Form2()
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
    }
}
