using System;
using Bak.Report.Domain.MiniPrograms;
using Volo.Abp.Domain.Repositories;

namespace Bak.Report.Domain.Orders
{
    /// <summary>
    /// IOrderRepository
    /// </summary>
    public interface IOrderRepository : IRepository<Order,Guid>
    {
        
    }
}