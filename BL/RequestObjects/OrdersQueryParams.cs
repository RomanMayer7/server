﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BL
{
    public class OrdersQueryParams
    {
        public long? ShopId;
        public int? UserId;
        public DateTime FromDate;
        public DateTime ToDate;
        public bool? IsRejected;
        public bool? IsReady;
        public bool? IsDelivered;

        internal void Validate()
        {
            if (FromDate > ToDate)
            {
                throw new Exception("FromDate can't be grater the ToDate.");
            }
        }
    }
}
