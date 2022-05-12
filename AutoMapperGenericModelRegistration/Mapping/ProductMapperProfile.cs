using AutoMapper;
using AutoMapperGenericModelRegistration.Dto;
using AutoMapperGenericModelRegistration.Model;

namespace AutoMapperGenericModelRegistration.Mapping
{
    public class ProductMapperProfile: Profile
    {
        public ProductMapperProfile()
        {
            //CreateMap<Product, ProductResponse>()
            //    .ReverseMap()
            //    .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
