using AutoMapperGenericModelRegistration.InterfaceMarker;
using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Dto
{
    public class CustomerResponse : IMapFrom<Customer>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
