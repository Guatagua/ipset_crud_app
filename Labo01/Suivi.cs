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
    public partial class Suivie : Form
    {
        public Suivie()
        {
            InitializeComponent();
        }
       

        private void Suivie_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Mobiledemande;
            Mobiledemande = txt_mobile.Text;

            ClDemande dem = new ClDemande();
            MySqlDataReader Rs;
            Rs = dem.Cherchermobile(Mobiledemande);
            DataTable dt = new DataTable();
            dt.Load(Rs);
            suivie_demande.DataSource = dt;
        }
    }
}
