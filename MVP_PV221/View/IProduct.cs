using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_PV221.View
{
    internal interface IProduct
    {
        decimal Count { get; set; }

        string PriceText { get; set; }  

        string CoastText { get; set; }  
    }
}
