using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace CPAstertaxer
{
    class MysqlConnect
    {
        public MySqlConnection
                GetDBConnection(string server, int portBase, string dBaseName, string Login, string Password)
        {
            // Connection String.
            String connString = "Server=" + server + ";Database=" + dBaseName
                + ";port=" + portBase + ";User Id=" + Login + ";password=" + Password;

            MySqlConnection condb = new MySqlConnection(connString);
            //DataBase.Data = condb;
            return DataBase.Data = condb;
        }

        //public MySqlConnection condb { get; set; }
    }
}
