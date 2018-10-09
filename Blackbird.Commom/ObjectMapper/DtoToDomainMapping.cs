using AutoMapper;

namespace Blackbird.Commom.ObjectMapper
{
    public class DtoToDomainMapping : ClassMappingBase
    {
        public override void ApplyMapping(IMapperConfigurationExpression cfg)
        {
            ApplyDefaultMapping(cfg);
            ApplyNonDefaultMapping(cfg);
        }

        protected override void ApplyDefaultMapping(IMapperConfigurationExpression cfg)
        {
            //var dtos = WhoImplementsThis(typeof(ITO));
            //var entities = WhoImplementsThis(typeof(IEntity));


            //foreach (var dto in dtos)
            //{
            //    var entity = entities.FirstOrDefault(c => c.Name + "TO" == dto.Name);
            //    if (dto != null)
            //    {
            //        cfg.CreateMap(dto, entity);
            //    }
            //}
        }

        protected override void ApplyNonDefaultMapping(IMapperConfigurationExpression cfg)
        {
            //throw new NotImplementedException();
        }
    }
}
