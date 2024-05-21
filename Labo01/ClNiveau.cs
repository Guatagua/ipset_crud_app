using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Labo01
{
    internal class ClNiveau
    {
        MySqlConnection cns = new MySqlConnection("server=localhost;uid=root;pwd=root;database=clogindb");


        public MySqlDataReader Lister_code_niveau()
        {
            try
            {
                string Query = "SELECT (niveau) FROM tblcniveausession";
                MySqlCommand cmd = new MySqlCommand(Query);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = cns;
                cns.Open();
                MySqlDataReader Rs = cmd.ExecuteReader();
                return Rs;

            }
            catch
            {
                MessageBox.Show("Opération non effectuée!", "Lister code niveau_session", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }
    }
}
