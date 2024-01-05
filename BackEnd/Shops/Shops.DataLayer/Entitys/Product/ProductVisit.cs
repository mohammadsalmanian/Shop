

using Shops.DataLayer.Entitys.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shops.DataLayer.Entitys.Product
{
    public class ProductVisit : BaseEntity
    {
        public long ProductId { get; set; }
        public string UserIp{ get; set; }

        #region relation
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
        #endregion
    }
}
