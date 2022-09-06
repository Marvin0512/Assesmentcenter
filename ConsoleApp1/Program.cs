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
            string connetionString = "host=localhost;port=3301;user=root;database=datamanipulation";

            using (MySqlConnection con = new MySqlConnection(connetionString))
            {
                try
                {
                    con.Open();
                    //------Hinzufügen-----
                    MySqlCommand command = new MySqlCommand("INSERT INTO `nahrungsmittel` (`id`, `name`, `mindesthaltbarkeitsdatum`) VALUES ('8', 'Pohl', '2069-01-03');", con);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Glück gehabt du Lappen");

                    //------Entfernen------
                    MySqlCommand command2 = new MySqlCommand("DELETE FROM `nahrungsmittel` WHERE `nahrungsmittel`.`id` = 8;", con);
                    command2.ExecuteNonQuery();

                    Console.WriteLine("Du hast einen Lauf oder so             du Lappen");

                    //-----ändern---------
                    MySqlCommand command3 = new MySqlCommand("UPDATE `nahrungsmittel` SET `mindesthaltbarkeitsdatum` = '2050-05-02 00:00:00' WHERE `nahrungsmittel`.`id` = 7;", con);
                    command3.ExecuteNonQuery();

                    Console.WriteLine("Bu bist trozdem Dumm");
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
