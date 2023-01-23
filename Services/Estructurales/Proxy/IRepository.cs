namespace Patrones_GOF.Services.Estructurales.Proxy
{
    public interface IRepository
    {
        public IList<Customer> GetAll();
        public void Save(Customer customer);
    }
}
