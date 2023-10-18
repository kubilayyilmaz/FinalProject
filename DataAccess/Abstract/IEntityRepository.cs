using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Her Dal sınıfında nesnemizin ismi ile methodlar oluşturmak yerine Generic yapı kullanabiliriz, bu repository sınıfda hepsinde olan methodlar yer alır.
    
    //IEntityRepository implemente eden nesnelerimizde vereceğimiz generic nesneyi sadece IEntity (kendisi) ve implemente eden nesneleri kullansın şeklinde kısıtlayabiliriz. Buna Generic Constraint denir.
    //Class : Referans Tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>>? filter = null); // p=>p.CategoryId == 2 şeklinde koşul yazabilmemezi sağlayan delegate
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
