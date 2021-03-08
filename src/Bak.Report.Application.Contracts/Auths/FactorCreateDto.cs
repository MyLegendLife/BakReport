using Bak.Report.Domain.Shared.Enums;
using System;

namespace Bak.Report.Application.Contracts.Auths
{
    /// <summary>
    /// 授权基础要素
    /// </summary>
    public class FactorCreateDto
    {
        public virtual FactorType Type { get; set; }

        public virtual string Vaule { get; set; }

        public virtual DateTime ExpireTime { get; set; }
    }
}
