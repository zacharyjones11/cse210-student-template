public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public decimal CalculateTotalPrice()
    {
        decimal productTotal = 0;
        foreach (Product product in _products)
        {
            productTotal += product.CalculateTotalCost();
        }

        decimal shippingCost = _customer.IsUsaCustomer() ? 5 : 35;

        return productTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        List<string> packingDetails = new List<string>();
        foreach (Product product in _products)
        {
            packingDetails.Add($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return string.Join("\n", packingDetails);
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
