public class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;

    public float TotalCost(int _quantity, float _price)
    {
        float _totalCost = _quantity * _price;
        return _totalCost;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public float GetPrice()
    {
        return _price;
    }

    public int GetID()
    {
        return _id;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }

    public void SetPrice(float price)
    {
        _price = price;
    }

    public void SetID(int id)
    {
        _id = id;
    }

    public void SetName(string name)
    {
        _name = name;
    }


}