using System.Net.Sockets;

class Customer
{
    //Class Attribute
    private string _name;
    private Address _address;

    //getter

    public Address GetAddress => _address; 
    //Class Constructor
    public Customer(string text, Address address)
    {
        _name = text;
        _address = address;

    }

    //Class Methods

    public void Display()
    {
        Console.WriteLine(_name);
        _address.Display();
        
    }

    public bool isUsa()
    {
        return _address.IsUsa();
    }

    
}