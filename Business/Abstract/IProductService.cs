using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetAllByUnityPrice(decimal min, decimal max);
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}