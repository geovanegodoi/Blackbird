using System;
using System.Collections.Generic;

namespace Blackbird.Application.Services
{
    public interface ICrudAppService<TKey, TDto> : IApplicationService
    {
        TDto Get(TKey id);

        ICollection<TDto> GetAll();

        TDto Create(TDto model);

        TKey CreateAndGetKey(TDto model);

        void Update(TKey id, TDto model);

        void Update(TDto model);

        void Delete(TKey id);

        void Delete(TDto model);
    }
}
