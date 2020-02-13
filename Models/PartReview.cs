using System;

namespace CheckMyVehicle.Models
{
    public class PartReview
    {
        public int Id { get; set; }
        public DateTime DateReview { get; set; }
        public string Diagnosis { get; set; }
        public int VehicleReviewId { get; set; }
        public int PartId { get; set; }
        public int EmplyeeId { get; set; }
    }
}