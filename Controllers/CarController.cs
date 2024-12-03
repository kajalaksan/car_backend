using CarEndals.Dtos.Request_DTo;
using CarEndals.Dtos.ResponceDto;
using CarEndals.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace CarEndals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpPost("Add-Car")]
        public async Task<IActionResult> AddCars(CarRequestDtos cars)
        {
            var data = await _carService.AddCars(cars);
            return Ok(data);
        }

        [HttpGet("Get_All-Car")]
        public async Task<IActionResult>GetAllCars()
        {
            var data = await _carService.GetAllCars();
            return Ok(data);
        }

        [HttpGet("Get_car_Id")]
        public async Task<IActionResult>GetCarById(Guid Id)
        {
            var data = await _carService.GetCarById(Id);
            return Ok(data);

        }
        [HttpGet ("Get_Cars-ByUser")]
        public async  Task<IActionResult>GetAllCarsbyUser()
        {
            var data = await _carService.GetAllCarsbyUser();
            return Ok(data);
        }
        [HttpPut("Update-car")]
        public async  Task<IActionResult>UpdateCars(Guid Id, CarRequestDtos carRequestDtos)
        {
            var data = await _carService.UpdateCars(Id, carRequestDtos);
            return Ok(data);
        }

        [HttpPut("update-delete-car")]
           public async  Task<IActionResult>UpdateDeteleCars(Guid Id, CarRequestDtos carRequestDtos)
        {
            var data = await _carService.UpdateDeteleCars(Id,carRequestDtos);
            return Ok(data);
        }
        [HttpDelete("delete-car")]
           public async  Task<IActionResult> DeleteCars(Guid Id)
        {
           await _carService.DeleteCars(Id);
            return NoContent();
        }
    }
}
