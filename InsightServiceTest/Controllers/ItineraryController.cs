using InsightService.Model;
using Microsoft.AspNetCore.Mvc;
using InsightServiceTest.Data_Access;

namespace InsightServiceTest.Controllers
{
    [ApiController]
    [Route("Itinerary/{action}")]
    public class ItineraryController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "test controller!!";
        }

        [HttpPost]
        public string Create([FromBody] Itinerary itinerary)
        {
            DataService dataService = new DataService();
            dataService.DoDBOperations(itinerary);
            var x = itinerary.TripName;
            return x;

        }
    }
}
