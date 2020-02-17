using System;
using System.Collections.Generic;
using CheckMyVehicle.Models;
using Pomelo.Data.MySql;

namespace CheckMyVehicle.Connector
{
    public class Conn
    {
        private string connstring;
        public Conn()
        {
            connstring = @"server=localhost;user=root;password=sonarpasswtest;database=sonar;";
        }

        public List<Vehicle> VehicleList()
        {
            List<Vehicle> allVehicle = new List<Vehicle>();

            using (MySqlConnection connMysql = new MySqlConnection(connstring))
            {
                using (MySqlCommand cmdd = connMysql.CreateCommand())
                {

                    cmdd.CommandText = "Select * from vehicle";
                    cmdd.CommandType = System.Data.CommandType.Text;

                    cmdd.Connection = connMysql;

                    connMysql.Open();

                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            allVehicle.Add(new Vehicle
                            {
                                LicensePlate = reader.GetString(reader.GetOrdinal("LicensePlate")),
                                Brand = reader.GetString(reader.GetOrdinal("Brand")),
                                Line = reader.GetString(reader.GetOrdinal("Line")),
                                Model = reader.GetInt32(reader.GetOrdinal("Model"))
                            });
                        }
                    }
                }

                connMysql.Close();
            }

            return allVehicle;
        }
    }
}
