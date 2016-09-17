using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkControls.Classes;
using MySql.Data.MySqlClient;

namespace UserManagement
{
    public class RoleDB : Entity
    {
        public RoleDB() : base()
        {
            adapter = new MySqlDataAdapter("SELECT * FROM role_tab",con);

            MySqlCommand ic = new MySqlCommand("INSERT INTO role_tab (role,description) VALUES (@role,@description)",con);
            ic.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            ic.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");

            adapter.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand("UPDATE role_tab SET description = @description WHERE role = @role",con);
            uc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");
            uc.Parameters.Add("@description", MySqlDbType.VarChar, 2000, "description");

            adapter.UpdateCommand = uc;

            MySqlCommand dc = new MySqlCommand("DELETE FROM role_tab WHERE role = @role", con);
            dc.Parameters.Add("@role", MySqlDbType.VarChar, 200, "role");

            adapter.DeleteCommand = dc;

        }
    }
}
