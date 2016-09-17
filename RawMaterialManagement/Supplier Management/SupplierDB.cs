using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using FrameworkControls.Classes;

namespace RawMaterialManagement.Supplier_Management
{
    class SupplierDB : Entity
    {

        public SupplierDB() : base()
        {
            adapter = new MySqlDataAdapter("select * from raw_supplier_tab", con);

            MySqlCommand ic = new MySqlCommand("RAW_SUPPLIER_INSERT", con);
            ic.CommandType = CommandType.StoredProcedure;
            ic.Parameters.Add("name_", MySqlDbType.VarChar, 200, "name");
            ic.Parameters.Add("contact_person_", MySqlDbType.VarChar, 200, "contact_person");
            ic.Parameters.Add("phone_", MySqlDbType.VarChar, 200, "phone");
            ic.Parameters.Add("email_", MySqlDbType.VarChar, 200, "email");
            ic.Parameters.Add("address_", MySqlDbType.VarChar, 200, "address");
            adapter.InsertCommand = ic;

            MySqlCommand uc = new MySqlCommand("RAW_SUPPLIER_UPDATE", con);
            uc.CommandType = CommandType.StoredProcedure;
            uc.Parameters.Add("name_", MySqlDbType.VarChar, 200, "name");
            uc.Parameters.Add("contact_person_", MySqlDbType.VarChar, 200, "contact_person");
            uc.Parameters.Add("phone_", MySqlDbType.VarChar, 200, "phone");
            uc.Parameters.Add("email_", MySqlDbType.VarChar, 200, "email");
            uc.Parameters.Add("address_", MySqlDbType.VarChar, 200, "address");
            uc.Parameters.Add("supplier_id_", MySqlDbType.Int32, 200, "supplier_id");
            adapter.UpdateCommand = uc;

            MySqlCommand dc = new MySqlCommand("delete from raw_supplier_tab where supplier_id = @supplierid", con);
            dc.Parameters.Add("@supplierid", MySqlDbType.VarChar, 200, "supplier_id");
            adapter.DeleteCommand = dc;
        }
    }
}
