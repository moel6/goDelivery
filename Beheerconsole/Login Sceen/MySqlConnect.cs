using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Login_Sceen
{
    class MySqlConnect
    {
        public MySqlConnection connString;

        public void Connection()
        {
            connString = new MySqlConnection(@"Server=localhost;  Uid=root; Database=dbi422354; Pwd=;SslMode=none");

        }

    }
}
