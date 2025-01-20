using lr3_1.Services;
using Microsoft.AspNetCore.Mvc;

namespace lr3_1.Controllers
{
    [Route("Calc")]
    public class CalcController : Controller
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("Add")]
        public IActionResult Add(int a, int b)
        {
            var result = _calcService.Add(a, b);
            return Content($"Результат: {result}");
        }

        [HttpGet("Subtract")]
        public IActionResult Subtract(int a, int b)
        {
            var result = _calcService.Subtract(a, b);
            return Content($"Результат: {result}");
        }

        [HttpGet("Multiply")]
        public IActionResult Multiply(int a, int b)
        {
            var result = _calcService.Multiply(a, b);
            return Content($"Результат: {result}");
        }

        [HttpGet("Divide")]
        public IActionResult Divide(int a, int b)
        {
            if (b == 0)
            {
                return Content("Помилка: на нуль ділити не можна");
            }
            var result = _calcService.Divide(a, b);
            return Content($"Результат: {result}");
        }
    }
}
