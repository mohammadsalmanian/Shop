

using Shops.DataLayer.Entitys.Common;

namespace Shops.DataLayer.Entitys.Product
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string ImageName { get; set; }
        public bool IsExist { get; set; }
        public bool IsSpecial { get; set; }
        #region Relation
        public ICollection<ProductVisit> productVisit { get; set; }
        public ICollection<ProductGallery> productGallery { get; set; }
        public ICollection<ProductSelectedCategory> productSelectedCategory { get; set; }
        #endregion
    }
}
