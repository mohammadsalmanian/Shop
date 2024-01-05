

using Shops.DataLayer.Entitys.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shops.DataLayer.Entitys.Product
{
    public class ProductCategory : BaseEntity
    {
        public int Title { get; set; }
        public long? ParentId { get; set; }

        #region Releation
        [ForeignKey("ParentId")]
        public ProductCategory ParentCategory { get; set; }
        public ICollection<ProductSelectedCategory> ProductSelectedCategory { get; set; }
        #endregion
    }
}
