using Bak.Report.Domain.MiniPrograms;
using Bak.Report.Domain.MiniPrograms.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.MiniPrograms
{
    public class MiniProgramRecordRepository : EfCoreRepository<ReportDbContext, MiniProgramRecord, int>, IMiniProgramRecordRepository
    {
        public MiniProgramRecordRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}