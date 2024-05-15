
namespace DIP
{
    public class CustomerService : ICustomerRepository
    {
        ICustomerRepository _customerRepository;
        public CustomerService( ICustomerRepository custumerRepository) {
        
        this._customerRepository = custumerRepository;
        }

    }
}
