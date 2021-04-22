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
    class AuctionLotService : IAuctionLotService
    {
        private ConnectionFactory connectionFactory = new ConnectionFactory();
        IAuctionLotRepository auctionLotRepository = new AuctionLotRepository();
        public List<AuctionLot> GetLots()
        {
            MySqlConnection connection = connectionFactory.ConnectionCar;
            try
            {
                return auctionLotRepository.GetLots(connection);
            }
            catch (Exception e)
            {
                connection.CancelQuery(100);
                throw e;
            }
        }

        public void ChangeTimeEnd(int timeEnd)
        {
            throw new ZeroException();
        }

        public void ChangeTopPrice(int price)
        {
            throw new ZeroException();
        }

        public void ChangeCurrentPrice(int price)
        {
            throw new ZeroException();
        }

        public void ChangeMinBet(int minBet)
        {
            throw new NotImplementedException();
        }
    }
}
