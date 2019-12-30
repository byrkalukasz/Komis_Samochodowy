using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Komis_Samochodowy.Models
{
    public class MockCarRepository : ICarRepository
    {
        private List<Car> Car;

        public MockCarRepository()
        {
            if (Car == null)
            {
                LoadCars();
            }
        }

        public IEnumerable<Car> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Car GetCarById(int _id)
        {
            throw new NotImplementedException();
        }

        private void LoadCars()
        {
            Car = new List<Car>
            {
                new Car{ Id = 1, Name = "Fiat", Model = "Punto", ModelYear = 2004, Millage = "120543", EngineSize = "1.2", Fuel = "Petrol", Power = "60 KM", Description = "Tanie auto polecam", Prize = 5000M, FotoURL = "/image/punto.jpg", MiniPhotoUrl = "/image/mini/punto.jpg", WeekCar = false }
                new Car{ Id = 2, Name = "Fiat", Model = "Tipo", ModelYear = 2018, Millage = "1000", EngineSize = "1.4", Fuel = "Petrol", Power = "140 KM", Description = "Tanie auto polecam", Prize = 30000M, FotoURL = "/image/tipo.jpg", MiniPhotoUrl = "/image/mini/punto.jpg", WeekCar = false }
                new Car{ Id = 3, Name = "Fiat", Model = "Stilo", ModelYear = 2006, Millage = "120543", EngineSize = "1.6", Fuel = "Petrol", Power = "80 KM", Description = "Tanie auto polecam", Prize = 8000M, FotoURL = "/image/stilo.jpg", MiniPhotoUrl = "/image/mini/punto.jpg", WeekCar = false }
                new Car{ Id = 4, Name = "Fiat", Model = "Punto", ModelYear = 2004, Millage = "120543", EngineSize = "1.2", Fuel = "Petrol", Power = "60 KM", Description = "Tanie auto polecam", Prize = 5000M, FotoURL = "/image/punto.jpg", MiniPhotoUrl = "/image/mini/punto.jpg", WeekCar = false }
                new Car{ Id = 5, Name = "Fiat", Model = "Punto", ModelYear = 2004, Millage = "120543", EngineSize = "1.2", Fuel = "Petrol", Power = "60 KM", Description = "Tanie auto polecam", Prize = 5000M, FotoURL = "/image/punto.jpg", MiniPhotoUrl = "/image/mini/punto.jpg", WeekCar = false }
                new Car{ Id = 6, Name = "Fiat", Model = "Punto", ModelYear = 2004, Millage = "120543", EngineSize = "1.2", Fuel = "Petrol", Power = "60 KM", Description = "Tanie auto polecam", Prize = 5000M, FotoURL = "/image/punto.jpg", MiniPhotoUrl = "/image/mini/punto.jpg", WeekCar = false }
            };
        }

    }
}
