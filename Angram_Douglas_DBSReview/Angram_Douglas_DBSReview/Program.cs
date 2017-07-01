using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Angram_Douglas_DBSReview
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = @"server=192.168.88.1;userid=dbsCon;password=thor;database=DBS; port=8889";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                MySqlDataReader rdr = null;
                conn.Open();

                Console.WriteLine("\r\nEnter a city");
                string stmCityInput = Console.ReadLine().ToLower();

                string stm = "SELECT city, temp, pressure, humidity from weather where city = \'" + stmCityInput + "\'";
                MySqlCommand cmd = new MySqlCommand(stm, conn);

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    while (rdr.Read())
                    {
                        Console.WriteLine("\r\n" + rdr.GetString(0) + "\r\nTemperature: " + rdr.GetInt32(1) + "\r\nPressure: " + rdr.GetInt32(2) + "\r\nHumidity: " + rdr.GetInt32(3) + "\r\n");
                    }

                    if (stmCityInput == "orlando")
                    {
                        Console.WriteLine("\r\n" + rdr.GetString(0) + "\r\nTemperature: " + rdr.GetInt32(1) + "\r\nPressure: " + rdr.GetInt32(2) + "\r\nHumidity: " + rdr.GetInt32(3) + "\r\n");
                    }
                }

                else
                {
                    Console.WriteLine("\r\nNo Data Available for selected city.\r\n");
                }

            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {

                if (conn != null)
                {
                    conn.Close();
                }

            }

            Console.WriteLine("Done");
        }
    }
}
