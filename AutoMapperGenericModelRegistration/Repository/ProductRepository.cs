using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ICollection<Product> _products;

        public ProductRepository()
        {
            _products = new HashSet<Product>()
            {
                new() { Id = Guid.NewGuid(), Name ="Pencil", Sku="RM1000", Secret="PencilSecret"},
                new() { Id = Guid.NewGuid(), Name ="Book", Sku="RM1001", Secret="BookSecret"},
                new() { Id = Guid.NewGuid(), Name ="Eraser", Sku="RM1002", Secret="EraserSecret"},
            };
        }

        public IEnumerable<Product> GetAll() => _products.ToList();
    }
}
