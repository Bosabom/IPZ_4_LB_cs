using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;
using IPZ_Proj.Validators;

namespace IPZ_Proj.Service
{
    interface IAuctionLotService
    {
        List<AuctionLot> GetLots();
        void ChangeTimeEnd([NonZeroValidator]int timeEnd);
        void ChangeTopPrice([NonZeroValidator]int price);
        void ChangeCurrentPrice([NonZeroValidator]int price);
        void ChangeMinBet(int minBet);

    }
}
