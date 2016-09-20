using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FrameworkControls.Classes
{
    public class EntityParentChild
    {
        public MySqlConnection con;
        public MySqlDataAdapter parentAdapter;
        public MySqlDataAdapter childAdapter;
        public DataSet dataSet = new DataSet();
        public DataTable parentTable = new DataTable("Parent");
        public DataTable childTable = new DataTable("Child");

        public EntityParentChild()
        {
            con = MySQLDatabaseAccess.Connection.getConnection();
            
        }

        public void Fill()
        {
            dataSet.Clear();
            parentAdapter.Fill(parentTable);
            childAdapter.Fill(childTable);

            string[] parent = {"user"};
            string[] child = {"child"};
            DataRelation rel = new DataRelation("relation", "Parent", "Child", parent, child , true);
            dataSet.Relations.Add(rel);
        }

        public void Save()
        {
            try
            {
                parentAdapter.Update(dataSet);
                System.Windows.Forms.MessageBox.Show("Saved");
                Fill();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void FillBy(MySqlCommand command)
        {
            dataSet.Clear();
            command.Connection = con;
            MySqlDataAdapter ad = new MySqlDataAdapter(command);

            ad.Fill(dataSet);
        }
    }
}
