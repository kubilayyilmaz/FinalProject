using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //I -> Onun interface olduğunu anlatır,
    //Product -> Hangi tabloya karşılık geldiğini anlatır,
    //Dal (Data Access Layer) veya Dao (Data Access Object) -> Onun hangi katmana karşılık geldiğini anlatır.

    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}

//Code Refactoring -> Kodun İyileştirilmesi