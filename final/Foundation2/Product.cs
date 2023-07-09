class Product
{
    private string _productName;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string productName, string productId, decimal price, int quantity)
    {
        _productName = productName;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetProductName(){
        return _productName;
    }

    public string GetProductId(){
        return _productId;
    }

    public decimal GetPrice(){
        return _price;
    }
    public int GetQuantity(){
        return _quantity;
    }

    public decimal GetTotalPrice()
    {
        return GetPrice() * GetQuantity();
    }
}
