using SalesManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer.Abstract
{
    public interface IEntityRepository<T>
        where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
        T Get(Expression<Func<T, bool>> expression = null);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
