using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICollection<Customer> _customers;

        public CustomerRepository()
        {
            _customers = new HashSet<Customer>()
            {
                new() { Id = Guid.NewGuid(), Name ="Furkan", Surname="Aslan", IdentityNumber="13579"},
            };
        }

        public IEnumerable<Customer> GetAll() => _customers.ToList();
    }
}
