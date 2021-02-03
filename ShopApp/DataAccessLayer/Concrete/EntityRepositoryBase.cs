using SalesManagement.Entities;
using SalesManagement.Entities.Abstract;
using ShopApp.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer
{
    public class EntityRepositoryBase<T> : IEntityRepository<T>
        where T : class, IEntity, new()
    {

        public virtual T Create(T entity)
        {
            using (var context = new SalesManagementContext())
            {              
                try
                {
                    T newEntity =  context.Set<T>().Add(entity);
                    context.SaveChanges();
                    return newEntity;
                }
                catch (Exception e)
                {
                    string message = e.Message;
                    return null;
                }
            }
        }

        public virtual void Delete(T entity)
        {
            using (var context = new SalesManagementContext())
            {
                try
                {
                    var deletedEntity = context.Entry(entity);
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        public virtual T Get(Expression<Func<T, bool>> expression = null)
        {
            using (var context = new SalesManagementContext())
            {
                try
                {
                    return context.Set<T>().FirstOrDefault(expression);
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> expression = null)
        {   
            using (var context = new SalesManagementContext())
            {
                try
                {
                    if (expression == null) return context.Set<T>().ToList(); 
                    else return context.Set<T>().Where(expression).ToList();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public virtual void Update(T entity)
        {
            using (var context = new SalesManagementContext())
            {
                try
                {
                    var updatedEntity = context.Entry(entity);
                    updatedEntity.State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
    }
}
