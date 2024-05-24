using System;
namespace InsightService.Model
{
    public class Itinerary
    {
        public string Id { get; set; }
        public string OrganizationId { get; set; }

        public string DivisionId { get; set; }

        public string RecordLocator { get; set; }

        public string TripName { get; set; }

        public string AccountId { get; set; }

        public string RIUserId { get; set; }

        public HotelSegment HotelSegment { get; set; }

        public AirSegment AirSegment { get; set; }

        public RailSegment RailSegment { get; set; }

        public CarSegment CarSegment { get; set; }

    }
}
