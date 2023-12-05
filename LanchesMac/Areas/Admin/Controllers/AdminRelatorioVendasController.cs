using KiDeliciasLanches.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;

namespace KiDeliciasLanches.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRelatorioVendasController : Controller
    {
        private readonly RelatorioVendasService _relatorioVendasServices;

        public AdminRelatorioVendasController(RelatorioVendasService relatorioVendasServices)
        {
            _relatorioVendasServices = relatorioVendasServices;
        }

        public async Task<IActionResult> Index(DateTime? minDate,
            DateTime? maxDate)
        {
            if(!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if(!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await _relatorioVendasServices.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
    }
}
