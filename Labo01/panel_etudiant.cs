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
    public partial class panel_etudiant : Form
    {
        public panel_etudiant()
        {
            InitializeComponent();
        }

        public void loadform(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form ;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
        }

        private void panel_etudiant_Load(object sender, EventArgs e)
        {
            //loadform(new Suivie());
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void panelheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //loadform(new Suivie());
            Suivie sv = new Suivie();
            sv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //loadform(new Demande());
            Demande sv = new Demande();
            sv.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
