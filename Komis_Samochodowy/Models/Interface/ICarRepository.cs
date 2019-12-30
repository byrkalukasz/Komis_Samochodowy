using System.Collections.Generic;

namespace Komis_Samochodowy.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCars();
        Car GetCarById(int _id);
    }
}
