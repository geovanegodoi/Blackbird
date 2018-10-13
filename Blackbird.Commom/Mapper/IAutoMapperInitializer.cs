using System;
using AutoMapper;

namespace Blackbird.Commom.Mapper
{
    public interface IAutoMapperInitializer
    {
        void RegisterTypes(IMapperConfiguration cfg);
    }
}
