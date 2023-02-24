namespace Assignment4;

public class CustomerRepository : IRepository<Customer>
{
    private List<Customer> _customers = new List<Customer>()
    {
        new Customer(1, "Mary"),
        new Customer(2, "Jack"),
        new Customer(3, "Bryan")
    };

    public void Add(Customer item)
    {
        _customers.Add(item);
    }

    public void Remove(Customer item)
    {
        foreach (var customer in _customers)
        {
            if (customer.Equals(item))
            {
                _customers.Remove(customer);
            }
        }
    }
}