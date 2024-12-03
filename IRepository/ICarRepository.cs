using CarEndals.Entities;

namespace CarEndals.IRepository
{
    public interface ICarRepository
    {
        Task<Cars> AddCars(Cars cars);
        Task<List<Cars>> GetAllCars();
        Task<Cars> GetCarById(Guid Id);
        Task<List<Cars>> GetAllCarsbyUser();
        Task<Cars> UpdateCars(Cars cars);
        Task<Cars> UpdateDeteleCars(Cars cars);
        Task DeleteCars(Guid Id);
    }
}
