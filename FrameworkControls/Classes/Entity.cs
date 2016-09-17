using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using MetroFramework.Forms;

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

        public void Save()
        {
            adapter.Update(dataSet);
            Fill();
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
