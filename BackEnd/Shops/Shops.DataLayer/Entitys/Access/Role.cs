
using Shops.DataLayer.Entitys.Common;
using System.ComponentModel.DataAnnotations;

namespace Shops.DataLayer.Entitys.Access
{
    public class Role : BaseEntity
    {
        [Display(Name = "نام سیستمی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Name { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Title { get; set; }

        #region relation
        public ICollection <UserRole> UserRoles { get; set; }
        #endregion
    }
}
