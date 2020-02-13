using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

using CheckMyVehicle.Models;

namespace CheckMyVehicle.Controllers
{
    public class VehiclesController : ControllerBase
    {
        public static List<Vehicle> vehicles = InitVehicles();
        

        [HttpGet("/Vehicle")]
        public IEnumerable<Vehicle> Get()
        {
            return vehicles;
        }
        
        [HttpPost("/Vehicle")]
        public void Post([FromBody] Vehicle vehicle)
        {
            vehicles.Add(vehicle);
            Console.WriteLine("Hecho");
        }

        private static List<Vehicle> InitVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle 
            { 
                LicensePlate = "1", 
                Brand = "Mark", 
                Line = "Line1", 
                Model = 30 
            });
            vehicles.Add(new Vehicle 
            { 
                LicensePlate = "2", 
                Brand = "Allan", 
                Line = "Line2", 
                Model = 35 
            });
            return vehicles;
        }
    }


}