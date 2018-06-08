namespace RepositoryPattern
{
    using System.Data.Entity;

    public interface IDbContext
    {
        IDbSet<T> Set<T>() where T:class;
        int Save();
    }
    public partial class dbModel : DbContext, IDbContext
    {
        public dbModel() : base("name=dbModel")
        {
        }

        public int Save()
        {
            return base.SaveChanges();
        }

        IDbSet<T> IDbContext.Set<T>()
        {
            return base.Set<T>();
        }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
