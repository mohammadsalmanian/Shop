using System;
using System.ComponentModel.DataAnnotations;
using Shapino.DataLayer.Entities.Account;
using Shapino.DataLayer.Entities.Common;

namespace Shapino.DataLayer.Entities.Access
{
    public class UserRole:BaseEntity
    {
        #region properties
        public long UserId { get; set; }
        public long RoleId { get; set; }
        #endregion

        #region Relations
        public User User { get; set; }
        public Role Role { get; set; }
        #endregion
    }
}
