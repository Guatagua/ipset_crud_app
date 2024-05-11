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
    internal class ClSpecialite
    {
        OleDbConnection cns = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Razek\OneDrive\Documents\Cours\C Sharp\Labos\Labo01\Labo01\data\dbipset.accdb");
        public void Ajouter(string Code, string Name)
        {
            try{
               string Query = "INSERT INTO specialite VALUES('" + Code + "','" + Name + "')";
               cns.Open();
               OleDbCommand cmd = cns.CreateCommand();
               cmd.CommandType = CommandType.Text;
               cmd.CommandText = Query;
               cmd.ExecuteNonQuery();
               cns.Close();
               MessageBox.Show("Enregistrer");
             }
            catch {
                 MessageBox.Show("Erreur de connexion");
            }
           
        }

        public OleDbDataAdapter Lister()
        {
            string Query = "SELECT * FROM specialite";
            OleDbCommand cmd = new OleDbCommand(Query);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cns;
            OleDbDataAdapter Rs = new OleDbDataAdapter();
            Rs.SelectCommand = cmd;
            return Rs;
        }


    }
}
