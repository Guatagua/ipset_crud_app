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
    public partial class Demande : Form
    {
        public Demande()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string Typedemande, Mobiledemande, Descdemande;
            Typedemande = txt_type.Text;
            Mobiledemande = txt_mobile.Text;
            Descdemande = txt_desc.Text;

            if (!string.IsNullOrEmpty(Typedemande) && Mobiledemande != "")
            {
                ClDemande Spt = new ClDemande();
                Spt.Ajouter(Typedemande, Mobiledemande, Descdemande);
                MessageBox.Show("Bien Ajouter");

            }
        }
    }
}
