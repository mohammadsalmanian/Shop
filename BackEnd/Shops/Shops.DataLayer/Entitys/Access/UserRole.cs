
using Shops.DataLayer.Entitys.Account;
using Shops.DataLayer.Entitys.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shops.DataLayer.Entitys.Access
{
    public class UserRole : BaseEntity
    {
        public long UserId { get; set; }

        public long RolesId { get; set; }


        #region relation
        public User User { get; set; }

        [ForeignKey(nameof(RolesId))]
        public virtual Role Role { get; set; }
        #endregion
    }
}

