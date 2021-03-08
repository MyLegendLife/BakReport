using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Base
{
    public class MerchanRepository : EfCoreRepository<ReportDbContext, Merchan>, IMerchanRepository
    {
        public MerchanRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        
    }
}