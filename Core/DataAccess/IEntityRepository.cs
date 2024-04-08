
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic Constraint
    //Class : referans tip olabilir  
    // IEntity : ıentity olabilir ya da ıentity i implemente eden nesne olabilir.
    public interface IEntityRepository <T>where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T,bool>>filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void add(T entity);
        void delete(T entity);
        void update(T entity);



    }
}
