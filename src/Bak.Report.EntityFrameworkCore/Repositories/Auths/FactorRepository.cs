using Bak.Report.Domain.Auths;
using Bak.Report.Domain.Auths.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Auths
{
    public class FactorRepository : EfCoreRepository<ReportDbContext, Factor, int>, IFactorRepository
    {
        public FactorRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}