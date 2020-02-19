using System;
using System.Collections.Generic;
using System.Text;

namespace Widget_Assinment {
    class GoldWidget : IProduct {

        private Product Product { get; set; }

        public double GetPrice() {
            return Product.GetPrice();
        }

        public string GetModelName() {
            return Product.GetModelName();
        }
 
        public string GetStateName() {
            return Product.GetStateName();
        }

        public GoldWidget() {
            Product = new Product {
                Code = "GW",
                Name = "Gold Widget",
                Model = ModelType.Gold
            };
        }

    }
}
