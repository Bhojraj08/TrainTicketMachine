namespace TrainTicketMachineDataAccess.Interface
{
    using System.Threading.Tasks;
   public interface ISearchStationDataManager
    {
        /// <summary>Gets the station asynchronous.</summary>
        /// <param name="stationCode">The station code.</param>
        /// <returns>The station Name</returns>
        Task<string> GetStationAsync(string stationCode);
    }
}
