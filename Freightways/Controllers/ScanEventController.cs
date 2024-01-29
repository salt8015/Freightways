using FreightwaysApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FreightwaysApi.Controllers
{
    [ApiController]
    [Route("v1/scans/[controller]")]
    public class ScanEventsController : ControllerBase
    {
        private readonly IScanEventService _scanEventService;
        private readonly ILogger<ScanEventsController> _logger;
        public ScanEventsController(ILogger<ScanEventsController> logger, IScanEventService scanEventService)
        {
            _scanEventService = scanEventService;
            _logger = logger;
        }

        /// <summary>
        /// Return scan events with an EventId greater than or equal to this
        /// </summary>
        /// <param name="fromEventId">The Id of the Event</param>
        /// <param name="limit">The total number of scan events to return(Default is 1)</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(int fromEventId, int limit = 1)
        {
            var result = await _scanEventService.Get(fromEventId, limit);
            return new JsonResult(result);
        }
    }
}
