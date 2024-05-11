using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Labo01
{
    internal class clLogin
    {
        OleDbConnection cns = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Razek\OneDrive\Documents\Cours\C Sharp\Labos\Labo01\Labo01\data\dbipset.accdb");
        
        public void Ajouter(string Login, string Pwd)
        {
            try
            {
                string Query = "INSERT INTO tlogin VALUES('" + Login + "','" + Pwd + "')";
                OleDbCommand cmd = new OleDbCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                cmd.ExecuteNonQuery();
            }catch
            {
                MessageBox.Show("Opération non effectuée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modifier(string Login, string Pwd)
        {
            try
            {
                string Query = "UPDATE tlogin SET login='" + Login + "' where pwd='" + Pwd + "'";
                OleDbCommand cmd = new OleDbCommand(Query);
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

        public void Suppression(string Login)
        {
            try
            {
                string Query = "DELETE FROM tlogin where login='" + Login + "'";
                OleDbCommand cmd = new OleDbCommand(Query);
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


        public OleDbDataReader Consulter(string Login)
        {
            try
            {
                string Query = "SELECT * FROM tlogin where login='" + Login + "'";
                OleDbCommand cmd = new OleDbCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                OleDbDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Consulter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public OleDbDataReader Lister(string Login)
        {
            try
            {
                string Query = "SELECT * FROM tlogin ORDER BY login";
                OleDbCommand cmd = new OleDbCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                OleDbDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Lister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public OleDbDataReader Chercher(string Login)
        {
            try
            {
                string Query = "SELECT * FROM tlogin where login like '%" + Login + "%'";
                OleDbCommand cmd = new OleDbCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                OleDbDataReader Rs = cmd.ExecuteReader();
                return Rs;
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Lister", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public bool Authentification(string Login, string Pwd)
        {
            try
            {
                bool Result = false;
                string Query = "SELECT * FROM tlogin WHERE login='" + Login + "' AND pwd='" + Pwd + "'";
                OleDbCommand cmd = new OleDbCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                OleDbDataReader Rs = cmd.ExecuteReader();
                if (Rs.HasRows) Result = true;
                cns.Close();
                return Result;
            }catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;   
            }
        }
    }
}
