using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blackbird.Commom.ExtendedTypes;

namespace Blackbird.Application.Services
{
    public interface ICrudAppService<TKey, TDto> : IApplicationService
    {
        TDto Get(TKey id);

        PaginatedList<TDto> GetAll(PagingCriteria criteria);

        TDto Create(TDto model);

        TKey CreateAndGetKey(TDto model);

        void Update(TKey id, TDto model);

        void Update(TDto model);

        void Delete(TKey id);

        void Delete(TDto model);
    }
}
