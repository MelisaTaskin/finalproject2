
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess

{

    //generic comstraint (generic kısıt  T'yi kısıtlarız)
    //class: reserans tip olabilir .
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir 
    //IEntity de kullanabilenler arasında yani(product category customer IEntity oluyor .)ama IEnitty interface yani doyut olduğu için onu dahil etmek istemediğimizden new() ekliyoruz ki IEntity dahil olmasın çünkü interface newlenemez dolayısıyla IEntitiy i newleyemediğimiz için uymaz ve yazmayız.
    public  interface IEntityRepository<T> where T : class , IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);

         T Get(Expression<Func<T, bool>> filter );

         
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        

    }
}
