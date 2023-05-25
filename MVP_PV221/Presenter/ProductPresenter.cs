using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MVP_PV221.Model;
using MVP_PV221.View;

namespace MVP_PV221.Presenter
{
    internal class ProductPresenter
    {
        IProduct productView;

        public ProductPresenter(IProduct product)
        {
            productView = product;
        }

        public void Coast()
        {
            Product product = new Product();
            product.Price = Convert.ToDecimal(productView.PriceText);
            product.Count = productView.Count;
            productView.CoastText = product.Coast().ToString();
        }
    }
}
