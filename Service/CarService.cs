using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Exceptions;
using IPZ_Proj.Model;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class CarService : ICarService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        ICarRepository carRepository = new CarRepository();
        public List<Car> GetCars()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return carRepository.GetCars(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }

      public void ChangeBrand(string brand)
        {
            throw new EmptyStringException();
        }

        public void ChangePrice(int price)
        {
            throw new ZeroException();
        }

        public void ChangeHP(int hp)
        {
            throw new ZeroException();
        }

        public void ChangeFuel(string fuel)
        {
            throw new FuelException();
        }

        public void ChangeDistance(int distance)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeCondition(string condition)
        {
            throw new ConditionException();
        }

        public void ChangeDescription(string description)
        {
            throw new System.NotImplementedException();
        }

        public void ChangeModel(string model)
        {
            throw new EmptyStringException();
        }

        public void ChangeYear(int year)
        {
            throw new InvalidYearException();
        }
    }
}
