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
    public partial class Traiter : Form
    {
        public Traiter()
        {
            InitializeComponent();
        }
        public void GetListDemande()
        {
            ClDemande Spt = new ClDemande();
            MySqlDataReader Rs;
            Rs = Spt.Consulter();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            traiter_list.DataSource = dt;

        }

        private void Traiter_Load(object sender, EventArgs e)
        {
            GetListDemande();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClDemande dem = new ClDemande();
            MySqlDataReader Rs;
            Rs = dem.Lister();
            DataTable dt = new DataTable();
            dt.Load(Rs);
            traiter_list.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String xIdSup;
            xIdSup = txt_id_sup.Text;

            ClDemande dem = new ClDemande();
            dem.Suppression(xIdSup);
            MessageBox.Show("Suppression effectuer");
            GetListDemande();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String xIdEtat, xChampEtat;
            xIdEtat = txt_id_etat.Text;
            xChampEtat = txt_champ_etat.Text;



            ClDemande dem = new ClDemande();
            dem.Modifier(xIdEtat, xChampEtat);
            MessageBox.Show("Modification effectuer");
            GetListDemande();
        }
    }
}
