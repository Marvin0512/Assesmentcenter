using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connetionString = "host=localhost;user=root;database=manipulation";

            using (MySqlConnection con = new MySqlConnection(connetionString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
                Console.ReadKey();
            }
        }
    }
}
