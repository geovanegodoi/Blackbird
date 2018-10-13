using System;
using System.Collections.Generic;
using Blackbird.Application.TO;
using Blackbird.Commom.Mapper;
using Blackbird.Domain.Entities;
using Blackbird.Domain.Repositories;

namespace Blackbird.Application.Services
{
    public abstract class CrudAppServiceBase<TKey, TDto, TRepository, TEntity> 
        : ApplicationServiceBase, ICrudAppService<TKey, TDto>
        where TDto : ITO
        where TRepository : IRepository<TKey, TEntity>
        where TEntity : IEntity<TKey>
    {
        private readonly TRepository _repository;

        protected TRepository Repository => _repository;

        protected CrudAppServiceBase(TRepository repository)
        {
            _repository = repository;
        }

        public TDto Create(TDto model)
        {
            var entity = model.MapTo<TEntity>();
            return _repository.Insert(entity).MapTo<TDto>();
        }

        public TKey CreateAndGetKey(TDto model)
        {
            var entity = model.MapTo<TEntity>();
            return _repository.InsertAndGetId(entity);
        }

        public void Delete(TKey id)
        {
            if (_repository.Get(id) == null)
            {
                throw new ApplicationException($"Invalid {nameof(id)} for delete operation");
            }
            _repository.Delete(id);
        }

        public void Delete(TDto model)
        {
            var entity = model.MapTo<TEntity>();
            _repository.Delete(entity);
        }

        public TDto Get(TKey id)
        {
            return _repository.Get(id).MapTo<TDto>();
        }

        public ICollection<TDto> GetAll()
        {
            return _repository.GetAll().MapTo<ICollection<TDto>>();
        }

        public void Update(TKey key, TDto model)
        {
            var entity = model.MapTo<TEntity>();
            _repository.Update(entity);
        }

        public void Update(TDto model)
        {
            var entity = model.MapTo<TEntity>();
            _repository.Update(entity);
        }
    }
}
