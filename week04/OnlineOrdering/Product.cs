class Product
{
    //Class Attribute
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;


    //getters

    // public int productId => _productId;
    // public string name => _name;


    //Constructor

    public Product(string name, int prodId, double price, int qty)
    {
        _name = name;
        _productId = prodId;
        _price = price;
        _quantity = qty;
    }


    //Class Methods

    public void Display()
    {
        Console.WriteLine($"Product: {_name}\nProduct ID: {_productId}\nPrice per unit: {_price}");
    }

    public double TotalProduct()
    {
        double total;

        total = _price * _quantity;

        return total;
    }

    public string Listing()
    {
        string info;

        info = $"ID:{_productId} - Product: {_name} - Quantity: {_quantity}"; 

        return info;
    }
    
    
}