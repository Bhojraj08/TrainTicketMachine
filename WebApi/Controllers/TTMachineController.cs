namespace TrainTicketMachineService.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TrainTicketMachineBusiness;
    using TrainTicketMachineBusiness.Interface;

    [Route("api/[controller]")]
    [ApiController]
    public class TTMachineController : ControllerBase

    {
        ISearchStationBusiness _ISearchStationBusiness { get; set; }
        public TTMachineController(ISearchStationBusiness searchStationBusiness)
        {
            this._ISearchStationBusiness = searchStationBusiness;
        }

        /// <summary>Gets the station asynchronous.</summary>
        /// <param name="stationCode">The station code.</param>
        /// <returns>The Result</returns>
        [HttpGet]
        public async Task<IActionResult> GetStationAsync(string stationCode)
        {

            var result = await _ISearchStationBusiness.GetStationAsync(stationCode);
            return Ok(result);
        }

    }

    
}