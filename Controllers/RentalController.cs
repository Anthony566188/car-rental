using car_rental.Data;
using car_rental.Dtos;
using car_rental.Services;
using Microsoft.AspNetCore.Mvc;

namespace car_rental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : ControllerBase
    {

        private readonly AppDbContext _context;
        private RentalService _service;

        public RentalController(AppDbContext context, RentalService service)
        {
            _context = context;
            _service = service;
        }

        [HttpPost("calculate")]
        public async Task<IActionResult> CalcularValorLocacao([FromBody] RentalCalculationRequest request)
        {
            // Busca o carro no banco de dados usando o CarroId do request
            var car = await _context.Cars.FindAsync(request.CarroId);
            if (car == null) return NotFound("Carro não encontrado.");

            var result = _service.Calculate(car, request.StartDate, request.EndDate);
            return Ok(result);
        }

    }
}
