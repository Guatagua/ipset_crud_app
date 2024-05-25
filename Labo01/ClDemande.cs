using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Labo01
{
    internal class ClDemande
    {
        MySqlConnection cns = new MySqlConnection("server=localhost;uid=root;pwd=root;database=clogindb");
        public void Ajouter(string Typedemande, string Mobile_etudian, string Descdemande)
        {
            try
            {
                string Query = "INSERT INTO tblcdemande (typedemande, mobiledemande, descdemande) VALUES ('" + Typedemande + "','" + Mobile_etudian + "','" + Descdemande +"')";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modifier(string Id, string Etat)
        {
            try
            {
                string Query = "UPDATE tblcdemande SET etatdemande='" + Etat + "' where id_demande='" + Id + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Modifier", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Suppression(string Id)
        {
            try
            {
                string Query = "DELETE FROM tblcdemande where id_demande='" + Id + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public MySqlDataReader Consulter()
        {
            try
            {
                string Query = "SELECT * FROM tblcdemande WHERE etatdemande LIKE 'en attente'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Consulter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public MySqlDataReader Lister()
        {
            try
            {
                string Query = "SELECT * FROM tblcdemande";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Lister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public MySqlDataReader Cherchermobile(string Mobiledemande)
        {
            try
            {
                string Query = "SELECT * FROM tblcdemande where mobiledemande like '%" + Mobiledemande + "%'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Chercher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
      


    }
}
