using ShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataAccessLayer
{
    public class EntityRepositoryBase<T> 
        where T : class, IEntity, new()
    {
        //Database
        private List<T> _enitites;
        private int _id;
        //Static constructor
        public EntityRepositoryBase()
        {
            _enitites = new List<T>();
        }

        public void Add(T entity)
        {
            _id++;
            entity.ID = _id;
            _enitites.Add(entity);
        }

        public void Remove(int id)
        {
            var entity = _enitites.SingleOrDefault(x => x.ID == id);
            _enitites.Remove(entity);
        }

        public List<T> GetAll()
        {
            return _enitites;
        }

        public T GetById(int id)
        {
            return _enitites.SingleOrDefault(x => x.ID == id);
        }
    }
}
