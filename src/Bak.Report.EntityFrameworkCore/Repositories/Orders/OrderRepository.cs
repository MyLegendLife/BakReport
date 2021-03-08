using Bak.Report.EntityFrameworkCore.EntityFrameworkCore;
using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Bak.Report.EntityFrameworkCore.Repositories.Orders
{
    /// <summary>
    /// OrderRepository
    /// </summary>
    public class OrderRepository : EfCoreRepository<ReportDbContext,Order,Guid>,IOrderRepository
    {
        public OrderRepository(IDbContextProvider<ReportDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}