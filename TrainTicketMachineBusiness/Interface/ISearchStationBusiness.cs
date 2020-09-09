using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketMachineBusiness.Interface
{
    public interface ISearchStationBusiness
    {
        /// <summary>Gets the station asynchronous.</summary>
        /// <param name="stationCode">The station code.</param>
        /// <returns>The Station name</returns>
        Task<string> GetStationAsync(string stationCode);
    }
}
