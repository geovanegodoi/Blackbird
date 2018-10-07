using System;
using System.Linq;
using AutoMapper;
using Blackbird.Application.TO;
using Blackbird.Domain.Entities;

namespace Blackbird.Commom.ObjectMapper
{
    public class DomainToDtoMapping : ClassMappingBase
    {
        public override void ApplyMapping(IMapperConfigurationExpression cfg)
        {
            ApplyDefaultMapping(cfg);
            ApplyNonDefaultMapping(cfg);
        }

        protected override void ApplyDefaultMapping(IMapperConfigurationExpression cfg)
        {
            var entities = WhoImplementsThis(typeof(IEntity));
            var dtos = WhoImplementsThis(typeof(ITO));


            foreach (var entity in entities)
            {
                var dto = dtos.FirstOrDefault(c => c.Name == entity.Name + "TO");
                if (dto != null)
                {
                    cfg.CreateMap(entity, dto);
                }
            }
        }

        protected override void ApplyNonDefaultMapping(IMapperConfigurationExpression cfg)
        {
            //throw new NotImplementedException();
        }
    }
}
