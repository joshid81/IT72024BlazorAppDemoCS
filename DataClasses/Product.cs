namespace IT72024BlazorAppDemoCS.DataClasses
{
    //public class Product
    //{
    //    public int ProductID;
    //    public string ProductName;

    //}

    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;

        public int Rate { get; set; }

        public int Quantity { get; set; }
    }
}
