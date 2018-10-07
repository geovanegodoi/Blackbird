using System;
using AutoMapper;

namespace Blackbird.Commom.ObjectMapper
{
    public interface IClassMapping
    {
        void ApplyMapping(IMapperConfigurationExpression cfg);
    }
}
