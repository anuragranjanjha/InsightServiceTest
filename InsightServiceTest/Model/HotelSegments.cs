using System;
namespace InsightService.Model
{
    public class HotelSegment
    {
        public DateTime StartDateTimeUTC { get; set; }
        public DateTime StopDateTimeUTC { get; set; }
        public string HotelName { get; set; }
        public string Phone { get; set; }
        public Location Location { get; set; }
        public string Address { get; set; }
    }

}
