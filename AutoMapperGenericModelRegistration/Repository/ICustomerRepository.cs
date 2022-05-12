using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
    }
}
