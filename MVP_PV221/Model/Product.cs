﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_PV221.Model
{
    internal class Product
    {
        public decimal Price { get; set; }         
        public decimal Count { get; set; }         

        public decimal Coast()
        {
            return Price * Count;
        }
    }
}
