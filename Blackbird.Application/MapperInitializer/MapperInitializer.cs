using System;
using Blackbird.Commom.Mapper;

namespace Blackbird.Application.MapperInitializer
{
    public class MapperInitializer : AutoMapperInitializerBase, IAutoMapperInitializer
    {
        public MapperInitializer() : base("Blackbird") { }

        public override void OverwriteSettings(IMapperConfiguration cfg)
        {

        }
    }
}
