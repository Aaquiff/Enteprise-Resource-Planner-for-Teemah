using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace RawMaterialManagement.Supplier_Management
{
    class DBItems
    {
        MySqlConnection con;
        MySqlDataAdapter itemAdapter;
        MySqlCommand insertCommand = new MySqlCommand();
        public DBItems()
        {
            con = new MySqlConnection("server=localhost;database=itp;user id=root;");
            itemAdapter = new MySqlDataAdapter("select * from item_tab", con);
            MySqlCommand insertCommand = new MySqlCommand("insert into item_tab values (@itemid,@itemname,@description)");
            //insertCommand.Parameters.Add("@itemid",MySqlDbType.)
        }
        
        
    }
}
