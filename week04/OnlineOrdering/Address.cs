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

}