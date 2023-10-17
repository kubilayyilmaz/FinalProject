using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> 
        //Her Dal sınıfında nesnemizin ismi ile methodlar oluşturmak yerine Generic yapı kullanabiliriz, bu repository sınıfda hepsinde olan methodlar yer alır.
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null); // p=>p.CategoryId == 2 şeklinde koşul yazabilmemezi sağlayan delegate
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
