public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public int IsUSA()
    {
        if (_country == "USA")
            // 1 = Is USA. 2 = Is Not USA.
            return 1;
        else return 0;
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress} {_city}, {_stateOrProvince} {_country}";
    }

    public string GetStreetAddress()
    {
        return _streetAddress;
    }

    public string GetCity()
    {
        return _city;
    }

    public string GetStateOrProvince()
    {
        return _stateOrProvince;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public void SetStateOrProvince(string stateOrProvince)
    {
        _stateOrProvince = stateOrProvince;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
}