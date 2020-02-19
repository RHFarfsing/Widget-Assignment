namespace Widget_Assinment {
    public enum ModelType { Bronse, Silver, Gold };

    class Product {
        public string Code { get; set; }
        public string Name { get; set; }
        public ModelType Model { get; set; }

        public double GetPrice() {
            return Model switch
            {
                ModelType.Bronse => 20,
                ModelType.Silver => 90,
                ModelType.Gold => 500,
                _ => 0 // everything else
            };
        }

        public string GetModelName() {
            return Model switch
            {
                ModelType.Bronse => "Bronse Widget",
                ModelType.Silver => "Silver Widget",
                ModelType.Gold => "Gold Widget",
                _ => "Not Found"
            };

        }

        public string GetStateName() {
            var statename = "";
            switch (Model) {
                case ModelType.Bronse:
                    statename = "Kentucky";
                    break;
                case ModelType.Silver:
                    statename = "Indiana";
                    break;
                case ModelType.Gold:
                    statename = "Ohio";
                    break;
                default:
                    statename = "not found";
                    break;
            }
            return statename;
        }

        public Product() {

        }
    }
}
