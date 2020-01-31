using System;
using System.Collections.Generic;
using System.Text;

namespace RewardZoneDomain.Models
{
    class Child : User
    {
        public int PointBalance { get; set; }

        public Child()
        {
            PointBalance = 0;
        }
    }
}
