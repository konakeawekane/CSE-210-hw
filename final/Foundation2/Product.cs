public class Product
{
    private string _name;
    private string _productID;
    private float _pricePerUnit;
    private int _quanitiy;

    public Product(string name, string id, float price, int quantity)
    {
        _name = name;
        _productID = id;
        _pricePerUnit = price;
        _quanitiy = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetID()
    {
        return _productID;
    }

    public float Totalcost()
    {
        return _pricePerUnit * _quanitiy;
    }
}
