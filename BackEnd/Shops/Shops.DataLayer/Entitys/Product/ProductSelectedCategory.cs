

using Shops.DataLayer.Entitys.Common;

namespace Shops.DataLayer.Entitys.Product
{
    public class ProductSelectedCategory : BaseEntity
    {
        public long ProductId { get; set; }
        public long ProductCategoryId { get; set; }

        #region relation
        public Product Product { get; set;} 
        public ProductCategory ProductCategory { get; set; }    
        public ICollection<ProductSelectedCategory> productSelectedCategories { get; set; } 
        #endregion
    }
}
