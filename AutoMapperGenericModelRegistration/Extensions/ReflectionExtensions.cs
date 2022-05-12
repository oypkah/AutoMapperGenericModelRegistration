namespace AutoMapperGenericModelRegistration.Extensions
{
    public static class ReflectionExtensions
    {
        public static IEnumerable<Type> GetGenericInterfaces(this Type type)
        {
            return type.GetInterfaces().Where(t => t.IsGenericType);
        }
        public static bool IsConstructableFrom(this Type type, Type genericTypeDefinition)
        {
            return type.IsConstructedGenericType &&
                (type.GetGenericTypeDefinition() == genericTypeDefinition);
        }
    }
}
