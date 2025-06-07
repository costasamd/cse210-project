using System.Reflection.Metadata.Ecma335;

class Order
{
    //Attributes
    private List<Customer> _customer = new List<Customer>();
    private List<Product> _products = new List<Product>();

    //Methods

    public void AddOrderProduct( Product newProduct)
    {
        _products.Add(newProduct);
    }

    public void AddOrderCustomer(Customer newCustomer)
    {
        _customer.Add(newCustomer);
    }

    public double TotalPrice()
    {
        double result = 0;
        double finalResult = 0;

        foreach (Customer customer in _customer)
        {
            if (customer.isUsa() == true)
            {
                foreach (Product item in _products)
                {
                    result += item.TotalProduct();
                    finalResult = result + 5;

                }

            }
            else if (customer.isUsa() == false)
            {
                foreach (Product item in _products)
                {
                    result += item.TotalProduct();
                    finalResult = result + 35;
                }
            }

        }

        return finalResult;
    }

    public void Packing()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.Listing());
        }
    }

    public void Shipping()
    {

        foreach (Customer customer in _customer)
        {

            customer.Display();
            Console.WriteLine($"Order Total: ${TotalPrice().ToString("0.00")}");
            //Console.WriteLine($"Shipping Order to:\n{customer.GetAddress.GetFullAddress()}\nTotal shipping price: ${TotalPrice().ToString("0.00")}");

        }
    }

    public void Display()
    {
        foreach (Customer p in _customer)
        {
            p.Display();
        }
    }

}