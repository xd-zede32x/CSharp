namespace Vending_machine_with_foods
{
    public class ProductInfo
    {
        public string Name => _name;
        public int Price => _price;

        private string _name { get; set; }
        private int _price { get; set; }

        public ProductInfo(string name, int price)
        {
            _name = name;
            _price = price;
        }
    }
}