using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CheckMyVehicle.Models
{
    public class Vehicle
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Line { get; set; }
        public int Model { get; set; }
    }

}