using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QualityWeek_CodingContest_AshutoshS2.Models
{
    public class NumberModel
    {
        enum NumberingSystem
        {
            Indian,
            Western
        }

        public decimal Amount { get; set; }

    }
}