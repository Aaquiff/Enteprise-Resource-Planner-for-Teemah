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

            MySqlCommand insertCommand = new MySqlCommand("insert into item_tab values (@itemid,@itemname,@description)", con);
            insertCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");
            insertCommand.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "item_name");
            insertCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");

            itemAdapter.InsertCommand = insertCommand;

            MySqlCommand updateCommand = new MySqlCommand("update item_tab set item_name = @itemname, description = @description where item_id = @itemid", con);
            updateCommand.Parameters.Add("@itemname", MySqlDbType.VarChar, 200, "item_name");
            updateCommand.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");
            updateCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");

            itemAdapter.UpdateCommand = updateCommand;

            MySqlCommand deleteCommand = new MySqlCommand("delete from item_tab where item_id = @itemid", con);
            deleteCommand.Parameters.Add("@itemid", MySqlDbType.VarChar, 200, "item_id");

            itemAdapter.DeleteCommand = deleteCommand;
        }
        
        
    }
}
