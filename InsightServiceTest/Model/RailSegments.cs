using System;
namespace InsightService.Model
{
    public class RailSegment
    {
        public string StartLocationTimeZone { get; set; }
        public string StopLocationTimeZone { get; set; }
        public string StartLocationName { get; set; }
        public string StopLocationName { get; set; }
        public StartLocation StartLocation { get; set; }
        public StopLocation StopLocation { get; set; }
        public string StartCountry { get; set; }
        public string StopCountry { get; set; }
        public string @operator { get; set; }
        public string TrainNumber { get; set; }
        public string StartLocationCode { get; set; }
        public string StopLocationCode { get; set; }
        public DateTime StartDateTimeUTC { get; set; }
        public DateTime StopDateTimeUTC { get; set; }
        public bool ReturnSegment { get; set; }
    }
}
