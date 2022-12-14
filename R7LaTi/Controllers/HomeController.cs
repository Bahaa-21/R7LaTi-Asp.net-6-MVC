using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using R7LaTi.IRepository;
using R7LaTi.Models;
using R7LaTi.ViewModel;
using System.Diagnostics;

namespace R7LaTi.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _service ;
        private readonly IMapper _mapper;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork service, IMapper mapper) => 
        (_logger, _service, _mapper) = (logger, service, mapper);

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            
            var trip = await _service.Trips.GetAllAsync();
            return View(_mapper.Map<IEnumerable<TripVM>>(trip));
        }
        
        [HttpGet]
        public async Task<IActionResult> DetailTrip(int id)
        {
            var trip = await _service.Trips.GetAsync(i => i.Id == id);
            return View(_mapper.Map<TripVM>(trip));
        }
    }
}