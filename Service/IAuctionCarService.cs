using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Text;
using IPZ_Proj.Model;
using IPZ_Proj.Validators;

namespace IPZ_Proj.Service
{
    interface IAuctionCarService
    {
        List<AuctionCar> GetCars();
        void ChangeBrand([NonEmptyStringValidator]string brand);
        void ChangePrice([NonZeroValidator] int price);
        void ChangeHP([NonZeroValidator] int hp);
        void ChangeFuel([FuelValidator]string fuel);
        void ChangeDistance(int distance);
        void ChangeCondition([ConditionValidator]string condition);
        void ChangeDescription(string description);
        void ChangeModel([NonEmptyStringValidator] string model);
        void ChangeYear([YearValidator]int year);
    }

}
