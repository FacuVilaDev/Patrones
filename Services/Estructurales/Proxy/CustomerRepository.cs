namespace Patrones_GOF.Services.Estructurales.Proxy
{
    public class CustomerRepository : IRepository
    {
        IList<Customer> _customers;
        public CustomerRepository()
        {
            _customers = new List<Customer>();
        }

        public IList<Customer> GetAll()
        {
            return _customers;
        }

        public void Save(Customer customer)
        {
            _customers.Add(customer);
        }
    }
}
