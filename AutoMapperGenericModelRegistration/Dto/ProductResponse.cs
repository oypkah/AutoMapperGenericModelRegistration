using AutoMapperGenericModelRegistration.InterfaceMarker;
using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Dto
{
    public class ProductResponse: IMapFrom<Product>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sku { get; set; }

    }
}
