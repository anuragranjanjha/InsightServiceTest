using System;

namespace InsightService.Model
{
    public class AirSegment
    {
        public string CarrierCode { get; set; }
        public string StartLocationTimeZone { get; set; }
        public string StopLocationTimeZone { get; set; }
        public string StartLocationName { get; set; }
        public string StopLocationName { get; set; }
        public StartLocation StartLocation { get; set; }
        public StopLocation StopLocation { get; set; }
        public string StartCountry { get; set; }
        public string StopCountry { get; set; }
        public string StartLocationCodeType { get; set; }
        public string StopLocationCodeType { get; set; }
        public string Carrier { get; set; }
        public string FlightNumber { get; set; }
        public string SegmentStatusCode { get; set; }
        public string StartLocationCode { get; set; }
        public string StopLocationCode { get; set; }
        public DateTime StartDateTimeUTC { get; set; }
        public DateTime StopDateTimeUTC { get; set; }
        public bool ReturnSegment { get; set; }
    }
}
