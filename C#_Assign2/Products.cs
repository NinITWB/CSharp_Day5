namespace Task2
{
    class Products
    {
        private int id;
        public int ID
        {
            get {return this.id;}
            set {this.id = value;}
        }

        private string name;
        public string Name
        {
            get {return this.name;}
            set {this.name = value;}
        }

        private string productionName;
        public string ProductionName
        {
            get {return this.productionName;}
            set {this.productionName = value;}
        }

        private double price;
        public double Price
        {
            get {return this.price;}
            set {this.price = value;}
        }

        private string otherDescriptions;
        public string OtherDescriptions
        {
            get {return this.otherDescriptions;}
            set {this.otherDescriptions = value;}
        }

        public Products() {}
        public Products(int id, string name, string productionName, double price, string otherDescriptions)
        {
            this.id = id;
            this.name = name;
            this.productionName = productionName;
            this.price = price;
            this.otherDescriptions = otherDescriptions;
        }

        public override string ToString()
        {
            return $"Id: {this.id}\n" +
                    $"Name: {this.name}\n" +
                    $"Production name: {this.productionName}\n" +
                    $"Price: {this.price}\n" +
                    $"Description: {this.otherDescriptions}\n";
        }
    }
}