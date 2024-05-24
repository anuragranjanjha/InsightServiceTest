using System;

namespace InsightService.Model
{
    public class CarSegment
    {
        public string StartLocationTimeZone { get; set; }
        public string StopLocationTimeZone { get; set; }
        public string TartLocationName { get; set; }
        public string StopLocationName { get; set; }
        public StartLocation StartLocation { get; set; }
        public StopLocation StopLocation { get; set; }
        public string StartCountry { get; set; }
        public string StopCountry { get; set; }
        public string CarCompany { get; set; }
        public string StartLocationCode { get; set; }
        public string StopLocationCode { get; set; }
        public DateTime StartDateTimeUTC { get; set; }
        public DateTime StopDateTimeUTC { get; set; }
    }
}
