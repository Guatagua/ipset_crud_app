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

        public void loadformsuivie(object form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void panel_etudiant_Load(object sender, EventArgs e)
        {
            loadformsuivie(new Suivie());    
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
            loadformsuivie(new Suivie());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadformsuivie(new Demande());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
