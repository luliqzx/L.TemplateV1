using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L.TemplateV1.Domain.Repository
{
    public interface IRepository : IReadOnlyRepository
    {
        void Create<TEntity>(TEntity entity)
            where TEntity : class;

        void Update<TEntity>(TEntity entity)
            where TEntity : class;

        void Delete<TEntity>(object id)
            where TEntity : class;

        void Delete<TEntity>(TEntity entity)
            where TEntity : class;

        void Save();

        Task SaveAsync();
    }
}
