class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public decimal TotalPrice()
    {
        decimal totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.GetTotalPrice();
        }

        if (customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string PackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.GetProductName()} (ID: {product.GetProductId()})\n";
        }

        return packingLabel;
    }

    public string ShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer: {customer.GetName()}\n";
        shippingLabel += $"Address:\n{customer.GetAddress().GetFullAddress()}";

        return shippingLabel;
    }
}
