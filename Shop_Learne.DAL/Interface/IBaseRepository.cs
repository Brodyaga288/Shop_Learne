using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Learne.DAL.Interface
{
    public interface IBaseRepository<T>
    {
        public IQueryable<T> GetAll();
        public Task<T> Create(T entity);
        public Task<T> Update(T entity);
        public Task<T> Delete(T entity);
    }
}
