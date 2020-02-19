using System;
using System.Collections.Generic;
using System.Text;

namespace Widget_Assinment {
    
    public class BronseWidget : IProduct{
        
        private Product Product { get; set; }
        
        public double GetPrice() {
            return Product.GetPrice();
        }
        public BronseWidget() {
            Product = new Product {
                Code = "BW",
                Name = "Bronze Widget",
                Model = ModelType.Bronse
            };
        }
    }
}
