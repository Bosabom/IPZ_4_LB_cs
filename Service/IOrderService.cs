﻿using System;
using System.Collections.Generic;
using System.Text;
using IPZ_Proj.Model;

namespace IPZ_Proj.Service
{
    interface IOrderService
    {
        List<Order> GetOrders();
    }
}
