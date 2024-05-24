using InsightService.Model;
using Npgsql;
using System;

namespace InsightServiceTest.Data_Access
{
    public class DataService
    {

        public void DoDBOperations(Itinerary itinerary)
        {
            try
            {
                var con = new NpgsqlConnection(
                connectionString: "Server=35.94.43.36;Port=5432;User Id=postgres;Password=postgres;Database=postgres;");
                con.Open();
                using var cmd = new NpgsqlCommand();
                cmd.Connection = con;

                cmd.CommandText = $"INSERT INTO itinerary (id, organizationid, divisionid, recordlocator, tripname, accountid, riuserid) VALUES (@id, @organizationid, @divisionid, @recordlocator, @tripname, @accountid, @riuserid)";
                cmd.Parameters.AddWithValue("id", itinerary.Id);
                cmd.Parameters.AddWithValue("organizationid", itinerary.OrganizationId);
                cmd.Parameters.AddWithValue("divisionid", itinerary.DivisionId);
                cmd.Parameters.AddWithValue("recordlocator", itinerary.RecordLocator);
                cmd.Parameters.AddWithValue("tripname", itinerary.TripName);
                cmd.Parameters.AddWithValue("accountid", itinerary.RIUserId);
                cmd.Parameters.AddWithValue("riuserid", itinerary.AccountId);
                cmd.Prepare();
                cmd.ExecuteNonQueryAsync();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
