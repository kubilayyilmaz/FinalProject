using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public const string ProductAdded = "Ürün eklendi";
        public const string ProductNameInvalid = "Ürün ismi geçersiz";
        public const string MaintenanceTime = "Sistemde bakımda";
        public const string ProductsListed = "Ürünler listelendi";
        public const string ProductCountOfCategoryError = "Bu kategoride maksimum 10 ürün olabilir";
        public const string ProductUpdated = "Ürün güncellendi";
        public const string ProductNameAlreadyExists = "Aynı isimde ürün zaten var";
        
        public const string CategoriesListed = "Kategoriler listelendi";
        public const string CategoryLimitExceeded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor";
    }
}