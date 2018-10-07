using AutoMapper;

namespace Blackbird.Commom.ObjectMapper
{
    public static class ObjectMapper
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                new DomainToDtoMapping().ApplyMapping(cfg);
                new DtoToDomainMapping().ApplyMapping(cfg);
            });
        }

        public static TDestination Map<TDestination>(object source)
        {
            return Mapper.Map<TDestination>(source);
        }

        public static TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
        {
            return Mapper.Map(source, destination);
        }
    }
}
