using AutoMapper;
using AutoMapperGenericModelRegistration.Extensions;
using AutoMapperGenericModelRegistration.InterfaceMarker;
using System.Reflection;

namespace AutoMapperGenericModelRegistration.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                                                                        !type.IsInterface &&
                                                                         type.GetGenericInterfaces().Any(generic => generic.IsConstructableFrom(typeof(IMapFrom<>))))
                                                                  .ToArray();

            foreach (var type in types)
            {
                var source = type.GetInterfaces()[0].GenericTypeArguments[0];

                CreateMap(source, type)
                .ReverseMap()
                .ForAllMembers(option => option.Condition((src, dest, srcMember) => srcMember != null));
            }
        }
    }
}
