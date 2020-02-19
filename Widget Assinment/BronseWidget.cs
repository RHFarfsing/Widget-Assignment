using System;
using System.Collections.Generic;
using System.Text;

namespace Widget_Assinment {
    
    public class BronseWidget : IProduct{
        
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

        public BronseWidget() { //this is done in the compostition, its the var that is assigned in the class that you are going to be pulling from
            Product = new Product {
                Code = "BW",
                Name = "Bronze Widget",
                Model = ModelType.Bronse
            };
        }
    }
}
