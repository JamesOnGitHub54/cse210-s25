public class Customer
{
    private string _name;

    // Creating Method to proceed. To call method from address.
    public int IsUSA(string _country)
    {
        if (_country == "USA")
            // 1 = Is USA. 2 = Is Not USA.
            return 1;
        else return 0;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    
}