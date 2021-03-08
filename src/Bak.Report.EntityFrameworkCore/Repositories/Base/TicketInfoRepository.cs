using Bak.Report.Domain.Base;
using Bak.Report.Domain.Base.Repositories;
using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Base
{
    public class ThirdTicketRepository : EfCoreRepository<ReportDbContext, ThirdTicket>, IThirdTicketRepository
    {
        public ThirdTicketRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 获取票据
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetTicketAsync()
        {
            var entity = await DbContext.Set<ThirdTicket>().FirstOrDefaultAsync();

            return entity == null ? "" : entity.Ticket;
        }
    }
}