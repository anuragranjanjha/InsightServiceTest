using Microsoft.EntityFrameworkCore;

namespace InsightService.Data_Access
{
    public class ItineraryContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=35.94.43.36:5432;Database=postgres;Username=postgres;Password=postgres");
    }

}
