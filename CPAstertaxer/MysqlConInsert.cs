using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
//using Tutorial.SqlConn;
//using System.Data.Common; 

namespace CPAstertaxer
{
     class MysqlConInsert
    {
         public void InsertSet(string server, int portBase, string dBaseName, string Login, string Password, string DataNum)
          {
  
            // Получить соединение к базе данных.
            MysqlConnect CondBase = new MysqlConnect();
            //MySqlConnection connection = DBUtils.GetDBConnection();
            MySqlConnection condb = DataBase.Data;
            condb.Open();
            try
            {    
                // Команда Insert.
                //string insql = "Insert into Salary_Grade (Grade, High_Salary, Low_Salary) " + " values (@grade, @highSalary, @lowSalary) ";
                string insql = "INSERT IGNORE INTO tblagents " + DataNum + "";

                MySqlCommand cmdb = new MySqlCommand();
                cmdb.CommandText = insql;  
 
                // Создать объект Parameter.
                MySqlParameter gradeParam = new MySqlParameter("@grade",SqlDbType.Int);
                gradeParam.Value = 3;
                cmdb.Parameters.Add(gradeParam);
 
                // Добавить параметр @highSalary (Написать кратко).
                MySqlParameter highSalaryParam = cmdb.Parameters.Add("@highSalary", SqlDbType.Float);
                highSalaryParam.Value = 20000;
 
                // Добавить параметр @lowSalary (Написать кратко).
                cmdb.Parameters.Add("@lowSalary", SqlDbType.Float ).Value = 10000; 
 
                // Выполнить Command (использованная для  delete, insert, update).
                int rowCount = cmdb.ExecuteNonQuery();
 
                Console.WriteLine("Row Count affected = " + rowCount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                condb.Close();
                condb.Dispose();
                condb = null;
            }
         }
    }
}


