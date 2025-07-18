public class Order
{
    public List<Product> _products = new List<Product>();
    public List<Customer> _Customers = new List<Customer>();

    public int TotalCost()
    {
        return 0;
    }

    public string GetPackingLabel()
    {
        return "";
    }

    public string GetShippingLabel()
    {
        return "";
    }

    

    

    
}