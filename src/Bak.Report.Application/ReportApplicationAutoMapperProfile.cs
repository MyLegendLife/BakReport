using AutoMapper;
using Bak.Report.Application.Contracts.Reports;
using Bak.Report.Domain.Reports;

namespace Bak.Report.Application
{
    public class ReportApplicationAutoMapperProfile : Profile
    {
        public ReportApplicationAutoMapperProfile()
        {
            //CreateMap<MiniProgramRegisterInput, MiniProgramRecord>()
            //    .ForMember(x => x.Id, map => map.Ignore())
            //    .ForMember(x => x.errcode, map => map.Ignore())
            //    .ForMember(x => x.errmsg, map => map.Ignore())
            //    .ForMember(x => x.CreationTime, map => map.Ignore())
            //    .ForMember(x => x.LastModificationTime, map => map.Ignore());

            //CreateMap<MiniProgramRecord, MiniProgramRecordDto>();

            //CreateMap<Authorizer, AuthorizerDto>();

            CreateMap<ReportCreateUpdateInput, ReportInfo>();
                //.ForMember(x => x.CreationTime, map => map.Ignore())
                //.ForMember(x => x.LastModificationTime, map => map.Ignore());

            CreateMap<ReportInfo, ReportInfoDto>()
                .ForMember(x => x.CategoryName, map => map.MapFrom(x => x.Category.Name));

            CreateMap<ReportCategoryDto, ReportCategory>();

            CreateMap<ReportCategory, ReportCategoryDto>();
        }
    }
}
