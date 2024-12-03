using CarEndals.Dtos.Request_DTo;
using CarEndals.Dtos.ResponceDto;

namespace CarEndals.IService
{
    public interface ICarService
    {
        Task<CarResponseDtos> AddCars(CarRequestDtos cars);
        Task<List<CarResponseDtos>> GetAllCars();
        Task<CarResponseDtos> GetCarById(Guid Id);
        Task<List<CarResponseDtos>> GetAllCarsbyUser();
        Task<CarResponseDtos> UpdateCars(Guid Id, CarRequestDtos carRequestDtos);
        Task<CarResponseDtos> UpdateDeteleCars(Guid Id, CarRequestDtos carRequestDtos);
        Task DeleteCars(Guid Id);
    }
}
