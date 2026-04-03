public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public float GetTotalCost()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total += product.Totalcost();
        }

        if (_customer.IsUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach(Product product in _products)
        {
            label += $"Item - {product.GetName()}, {product.GetID()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress -\n{_customer.GetAddress()}";
    }
}