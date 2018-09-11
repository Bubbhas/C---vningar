using CheckPoint5.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CheckPoint5
{
    class DataAccess
    {
        string conString = @"Server=(localdb)\mssqllocaldb;Database=GnomeDb";

        internal List<Gnome> GetGnomesFromDatabase()
        {
            var Gnomes = new List<Gnome>();
            //string sql = @"Gnome.Id, Gnome.Name From Gnome";

            string sql = @"Select Gnome.Id, Gnome.Name, Gnome.Beard, Nice.Name, Temper.Temper, Race.Name
                            From Gnome
                            Join Temper On Temper.Id = Gnome.Temper
                             Join Nice On Nice.Id = Gnome.Nice
                            Join Race ON Race.Id = Gnome.Race";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    var gnome = new Gnome();
                    gnome.Id = reader.GetSqlInt32(0).Value;
                    gnome.Name = reader.GetSqlString(1).Value;
                    //kollar om skägg är true or false, lägger därtill in värde
                    if (reader.GetSqlBoolean(2).Value)
                        gnome.Beard = "ja";
                    else
                        gnome.Beard = "nej";
                    //tabell har skapats där med string ja eller nej
                    gnome.Nice = reader.GetSqlString(3).Value;
                    gnome.Temper = reader.GetSqlInt32(4).Value;
                    gnome.Race = reader.GetSqlString(5).Value;

                    Gnomes.Add(gnome);
                }
            }
            return Gnomes;
        }

        internal void AddGnome(string name)
        {
            
            string sql = @"INSERT INTO Gnome(Name)
                            Values (" + SafeDBString(name) + ")";
            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                Console.WriteLine(sql);
                connection.Open();
                //command.Parameters.Add(new SqlParameter("@Name", name));
                command.ExecuteNonQuery();
            }

            }
        string SafeDBString(string inputValue)
        {
            return "'" + inputValue.Replace("'", "''") + "'";
        }
    }
}
