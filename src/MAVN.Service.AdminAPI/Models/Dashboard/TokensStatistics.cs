﻿using System;
using Falcon.Numerics;

namespace MAVN.Service.AdminAPI.Models.Dashboard
{
    public class TokensStatistics
    {
        public DateTime Day { get; set; }

        public Money18 Amount { get; set; }
    }
}
