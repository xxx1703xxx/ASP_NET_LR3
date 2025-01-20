using lr3_1.Services;
using Microsoft.AspNetCore.Mvc;


namespace lr3_1.Controllers
{
    [Route("Time")]
    public class TimeController : Controller
    {
        private readonly TimeService _timeService;

        public TimeController(TimeService timeService)
        {
            _timeService = timeService;
        }

        [HttpGet("CurrentTime")]
        public IActionResult CurrentTime()
        {
            var timeOfDay = _timeService.GetCurrentTimeOfDay();
            return Content($"Зараз {timeOfDay}");
        }
    }
}
