using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Repositories.Interfaces
{
    public interface IGenericRepository<T>:IDisposable
    {
        IEnumerable<T> GetAll(
            Expression<Func<T,bool>> filter=null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy=null ,
            string IncludeProperties= "");

        T GetById(object id);
        Task<T> GetByIdAsync(object id); 
        void Add(T entity);

        Task<T> AddAsync(T entity);
        void Update(T entity);  
        Task<T> UpdateAsync(T entity);  
        Task Delete(T entity);  
        Task DeleteAsync(T entity); 




    }
}
