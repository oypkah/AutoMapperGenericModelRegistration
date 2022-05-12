using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
    }
}
