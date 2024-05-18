using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities;
using System.IO;


namespace Labo01
{
    internal class ClLogin
    {
        string imageLocation = "";

        MySqlConnection cns = new MySqlConnection("server=localhost;uid=root;pwd=root;database=clogindb");
        public void Ajouter(string NomComplet, string Username, string Password, string DateNaissance, string Sexe, string Mobile, string Email, string Niveau, string Specialite)
        {
            try
            {
                string Query = "INSERT INTO tblclogin (nomcomplet,username,password,datenaissance,sexe,mobile,email,niveau,specialite) VALUES ('" + NomComplet + "','" + Username + "','" + Password + "','" + DateNaissance+ "','" + Sexe + "','" + Mobile + "','" + Email + "','" + Niveau + "','" + Specialite + "')";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();

                byte[] images = null;
                FileStream stream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
                cmd.Parameters.Add(new MySqlParameter("@image", images));

                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Ajout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modifier(string Login, string Pwd)
        {
            try
            {
                string Query = "UPDATE tblclogin SET username='" + Login + "' where password='" + Pwd + "'";
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
                string Query = "DELETE FROM tblclogin where id='" + Id + "'";
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
                string Query = "SELECT * FROM tblclogin ORDER BY username";
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
                string Query = "SELECT * FROM tblclogin";
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

        public MySqlDataReader Chercher(string Username)
        {
            try
            {
                string Query = "SELECT * FROM tblclogin where username like '%" + Username + "%'";
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

        public bool Authentification(string Login, string Pwd)
        {
            try
            {
                bool Result = false;
                string Query = "SELECT * FROM tblclogin WHERE username='" + Login + "' AND password='" + Pwd + "'";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                if (Rs.HasRows) Result = true;
                cns.Close();
                return Result;
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Authentification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;   
            }
        }
    }
}
