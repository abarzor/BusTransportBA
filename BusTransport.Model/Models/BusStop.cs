using NetTopologySuite.Geometries;

namespace BusTransport.Model.Models
{
    public class BusStop
    {
        public int BusStop_Id { get; set; }
        public string StopName { get; set; }
        public TimeOnly Arrival { get; set; }
        public TimeOnly Departure { get; set; }
        public double BusStopLocationX { get; set; }
        public double BusStopLocationY { get; set; }
    }
}
