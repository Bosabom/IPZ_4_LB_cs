using IPZ_Proj.Model;
using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.DataBase;
using IPZ_Proj.Exceptions;
using IPZ_Proj.Repository;
using MySql.Data.MySqlClient;

namespace IPZ_Proj.Service
{
    class UsersCarService : IUsersCarService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IUsersCarRepository usersCarRepository = new UsersCarRepository();
        public List<UsersCar> GetUsersCars()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return usersCarRepository.GetUsersCars(connection);
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
            throw new NotImplementedException();
        }

        public void ChangeCondition(string condition)
        {
            throw new ConditionException();
        }

        public void ChangeDescription(string description)
        {
            throw new NotImplementedException();
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
