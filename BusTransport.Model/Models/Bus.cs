using NetTopologySuite.Geometries;

namespace BusTransport.Model.Models
{
    public class Bus
    {
        public int Bus_Id { get; set; }
        public int NumberOfSeats { get; set; }
        public string VehicleBrand { get; set; }
        public bool IsOnRoad { get; set; } = false;
        public double BusLocationX { get; set; }
        public double BusLocationY { get; set; }

        public Course Course { get; set; }
    }
}