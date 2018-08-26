namespace Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory _dbFactory;
        private ShopOnlineDbContext _dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public ShopOnlineDbContext DbContext
        {
            get
            {
               return (_dbContext ?? (_dbContext = _dbFactory.Init()));
            }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
