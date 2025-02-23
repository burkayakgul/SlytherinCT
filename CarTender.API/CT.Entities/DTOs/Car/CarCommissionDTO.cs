﻿using System;

namespace CT.Entities.Car
{
    public class CarCommissionDTO
    {
        public decimal Price { get; set; }
        public string Information { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}

