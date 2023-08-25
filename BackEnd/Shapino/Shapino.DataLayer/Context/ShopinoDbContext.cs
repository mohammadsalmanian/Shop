using Microsoft.EntityFrameworkCore;

namespace Shapino.DataLayer.Context
{
    public class ShopinoDbContext:DbContext
    {
        #region
        //*دی بی کانتکست آپشن به صورت جنریک یعنی  <>
        //بیس را فراخوانی و میگوییم آپشن را دریافت کن
        public ShopinoDbContext(DbContextOptions<ShopinoDbContext> options) : base(options)
        {

        }
        #endregion
        #region disale cascading delete in database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //اول از داخل مادل بیلدر تمامی آیتم هایی که به صورت کسکید دلیت هستند را انتخاب میکنیم
            var cascades = modelBuilder.Model.GetEntityTypes()
                            .SelectMany(t=>t.GetForeignKeys())
                            .Where(fk=>fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);
            foreach (var fk in cascades)
            {
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            }
            base.OnModelCreating(modelBuilder);
        }     
    

        #endregion
    }
}
