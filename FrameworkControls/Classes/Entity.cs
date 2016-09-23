using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Windows;

namespace FrameworkControls.Classes
{
    public class Entity
    {
        public MySqlConnection con;
        public MySqlDataAdapter adapter;
        public DataSet dataSet = new DataSet();

        public Entity()
        {
            con = MySQLDatabaseAccess.Connection.getConnection();
        }

        public void Fill()
        {
            dataSet.Clear();
            adapter.Fill(dataSet);
        }

        public bool Save()
        {
            adapter.Update(dataSet);
            Fill();
            return true;            
        }

        public void FillBy(MySqlCommand command)
        {
            try
            {
                dataSet.Clear();
                command.Connection = con;
                MySqlDataAdapter ad = new MySqlDataAdapter(command);

                ad.Fill(dataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
