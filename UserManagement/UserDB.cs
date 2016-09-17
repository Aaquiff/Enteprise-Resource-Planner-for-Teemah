using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrameworkControls.Classes;
using MySql.Data.MySqlClient;

namespace UserManagement
{
    class UserDB : EntityParentChild
    {
        public UserDB() : base()
        {
            parentAdapter = new MySqlDataAdapter("select * from user", con);
            childAdapter = new MySqlDataAdapter("select * from user_role",con);
        }
    }
}
