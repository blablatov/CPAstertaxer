using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace CPAstertaxer
{
    class MysqlConSelect
    {
        //static string tempmarker, tempDataNum;
        //static string reqsql, reqsql2, reqsql3;
        //MySqlConnection condb;  
        public void SelectGet(string server, int portBase, string dBaseName, string Login, string Password)
        {
            // Получить объект Connection подключенный к DB.
            MysqlConnect CondBase = new MysqlConnect();
            CondBase.GetDBConnection(server, portBase, dBaseName, Login, Password);
            //tempmarker = marker;
            //tempDataNum = DataNum;
            MySqlConnection condb = DataBase.Data;
            condb.Open();
            try
            {
                QueryEmployee(condb);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                MessageBox.Show(e.StackTrace);
            }
            finally
            {
                // Закрыть соединение.
                condb.Close();
                // Уничтожить объект, освободить ресурс.
                condb.Dispose();
            }
        }

        private static void QueryEmployee(MySqlConnection condb)
        {
            MySqlCommand cmdb = new MySqlCommand();
            string reqsql = "SELECT * FROM tblagents";

            /*if (tempmarker == "RegToDB") 
            reqsql = "SELECT * FROM tblagents";
            cmdb.Connection = condb;
            cmdb.CommandText = reqsql;

            if (tempmarker == "CheckWhoReg") 
            reqsql2 = "INSERT IGNORE INTO tblagents " + tempDataNum + "";
            cmdb.Connection = condb;
            cmdb.CommandText = reqsql2;

            if (tempmarker == "CheckWhoReg")
            reqsql3 = "INSERT IGNORE INTO tblagents (`agents`) VALUES ('${EXTEN}'))";
            cmdb.Connection = condb;
            cmdb.CommandText = reqsql3;*/

            // Создать объект Command.
            //MySqlCommand cmdb = new MySqlCommand();

            // Сочетать Command с Connection.
            cmdb.Connection = condb;
            cmdb.CommandText = reqsql;

            using (DbDataReader reader = cmdb.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Индекс (index) столбца ID в команде SQL. "Select Emp_Id, Emp_No, Emp_Name, Mng_Id from Employee";
                        int empIdIndex = reader.GetOrdinal("id"); // Возвращает порядковый номер столбца id. 
                        long empId = Convert.ToInt32(reader.GetValue(empIdIndex));//	Возвращает значение указанного столбца как экземпляр Object.

                        // Индекс (index) столбца agents в команде SQL. 
                        int empAgentsIndex = reader.GetOrdinal("agents"); // Возвращает порядковый номер столбца agents. 
                        string empAgent = Convert.ToString(reader.GetValue(empAgentsIndex));//	Возвращает значение указанного столбца как экземпляр Object.

                        // Индекс (index) столбца time_create в команде SQL. 
                        int empTimeIndex = reader.GetOrdinal("time_create"); // Возвращает порядковый номер столбца time. 
                        string empTime = Convert.ToString(reader.GetValue(empTimeIndex));// Возвращает значение указанного столбца как экземпляр Object.

                        // Индекс (index) столбца val в команде SQL. 
                        int empValIndex = reader.GetOrdinal("val"); // Возвращает порядковый номер столбца val. 
                        string empVal = Convert.ToString(reader.GetValue(empValIndex));// Возвращает значение указанного столбца как экземпляр Object.
                       
                        MessageBox.Show("id: " + empId + " agents: " + empAgent + " time_create: " + empTime);
                    }
                }
            }
        }
    }
}
