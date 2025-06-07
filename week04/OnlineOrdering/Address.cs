class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUsa;

    //Class Constructor

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    //getter

    public bool getIsUsa => _isUsa;

    //Class Methods

    public bool IsUsa()
    {
        _isUsa = true;

        if (_country == "USA")
        {
            _isUsa = true;
        }
        else
        {
            _isUsa = false;
        }

        return _isUsa;

    }
    public string GetFullAddress()
    {
        string fullAddress;

        fullAddress = $"{_street}\n{_city} - {_state}\n{_country}";
        

        return fullAddress;
    }

    public void Display()
    {
        Console.WriteLine($"{_street}\n{_city} - {_state}\n{_country}");
    }
}