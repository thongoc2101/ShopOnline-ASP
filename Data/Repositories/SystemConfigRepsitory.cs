using Data.Infrastructure;
using Model.Models;

namespace Data.Repositories
{
    public interface ISystemConfigRepsitory : IRepository<SystemConfig>
    {

    }
    public class SystemConfigRepsitory : RepositoryBase<SystemConfig>, ISystemConfigRepsitory
    {
        public SystemConfigRepsitory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
