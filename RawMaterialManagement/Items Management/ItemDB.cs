using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using FrameworkControls.Classes;

namespace RawMaterialManagement.Items_Management
{
    
    class ItemDB : Entity
    {

        public ItemDB() : base()
        {
            //con = MySQLDatabaseAccess.Connection.getConnection();

            adapter = new MySqlDataAdapter("select * from raw_item_tab", con);

            MySqlCommand ic = new MySqlCommand
                ("RAW_ITEM_INSERT", con);
            //insertCommand.Parameters.Add("@itemid", MySqlDbType.Int32, 200, null);
            ic.CommandType = CommandType.StoredProcedure;
            ic.Parameters.Add("name_", MySqlDbType.VarChar, 2000, "name");
            ic.Parameters.Add("description_", MySqlDbType.VarChar, 2000, "description");
            ic.Parameters.Add("stock_level_", MySqlDbType.Int32, 200, "stock_level");
            ic.Parameters.Add("unit_of_measure_", MySqlDbType.VarChar, 20, "unit_of_measure");
            ic.Parameters.Add("item_category_", MySqlDbType.VarChar, 200, "item_category");
            ic.Parameters.Add("bar_code_", MySqlDbType.VarChar, 200, "bar_code");
            adapter.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand
                ("RAW_ITEM_UPDATE", con);
            uc.CommandType = CommandType.StoredProcedure;
            uc.Parameters.Add("name_", MySqlDbType.VarChar, 2000, "name");
            uc.Parameters.Add("description_", MySqlDbType.VarChar, 2000, "description");
            uc.Parameters.Add("stock_level_", MySqlDbType.Int32, 11, "stock_level");
            uc.Parameters.Add("unit_of_measure_", MySqlDbType.VarChar, 20, "unit_of_measure");
            uc.Parameters.Add("item_category_", MySqlDbType.VarChar, 200, "item_category");
            uc.Parameters.Add("bar_code_", MySqlDbType.VarChar, 200, "bar_code");
            uc.Parameters.Add("item_id_", MySqlDbType.Int32, 200, "item_id");
            adapter.UpdateCommand = uc;

            MySqlCommand dc = new MySqlCommand("DELETE FROM raw_item_tab WHERE item_id = @item_id",con);
            dc.Parameters.Add("@item_id", MySqlDbType.Int32, 10000, "item_id");
            adapter.DeleteCommand = dc;
        }  

    }
}
