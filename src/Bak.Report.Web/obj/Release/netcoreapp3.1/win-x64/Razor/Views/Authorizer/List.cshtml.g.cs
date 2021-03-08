﻿#pragma checksum "D:\Projects\Bak.Report\src\Bak.Report.Web\Views\Authorizer\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f98b14b5c501872c13d0fd8aa359af3ce8f00e66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authorizer_List), @"mvc.1.0.view", @"/Views/Authorizer/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\Bak.Report\src\Bak.Report.Web\Views\_ViewImports.cshtml"
using Bak.Report.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Bak.Report\src\Bak.Report.Web\Views\_ViewImports.cshtml"
using Bak.Report.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Projects\Bak.Report\src\Bak.Report.Web\Views\Authorizer\List.cshtml"
using Volo.Abp.Application.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\Bak.Report\src\Bak.Report.Web\Views\Authorizer\List.cshtml"
using Bak.Report.Application.Contracts.Auths;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f98b14b5c501872c13d0fd8aa359af3ce8f00e66", @"/Views/Authorizer/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc7dbc6717b380374bcddf00dec8f236a14124e", @"/Views/_ViewImports.cshtml")]
    public class Views_Authorizer_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedResultDto<AuthorizerDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Projects\Bak.Report\src\Bak.Report.Web\Views\Authorizer\List.cshtml"
  
    ViewData["Title"] = "申请开通直播 - 小程序";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<fieldset class=\"layui-elem-field layui-field-title\" style=\"margin-top: 50px;\">\r\n    <legend>申请开通直播</legend>\r\n</fieldset>\r\n<table id=\"table\" lay-filter=\"test\"></table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        layui.use('table',
            function () {
                var table = layui.table;

                //第一个实例
                table.render({
                    elem: '#table',
                    height: 500,
                    //url: './list', //数据接口
                    url: 'list', //数据接口
                    method: 'post',
                    parseData: function (res) { //res 即为原始返回的数据
                        return {
                            ""code"": res.code, //解析接口状态
                            ""msg"": res.message, //解析提示文本
                            ""count"": res.result.totalCount, //解析数据长度
                            ""data"": res.result.items //解析数据列表
                        };
                    },
                    page: true //开启分页
                    ,
                    cols: [
                        [//表头
                            { field: 'head_img', title: '头像', align: 'center',width:150, fixed: 'left',templet: ""#imgTemp"" },
           ");
                WriteLiteral(@"                 { field: 'nick_name', title: '昵称', sort: true },
                            { field: 'user_name', title: '原始ID', sort: true },
                            { field: 'principal_name', title: '主体名称', sort: true },
                            { field: 'authorizer_appid', title: '客户ID', sort: true, fixed: 'left' },
                            { field: 'CreationTime', title: '创建时间', sort: true },
                            { fixed: 'right', width: 150, align: 'center', toolbar: '#barDemo' } //这里的toolbar值是模板元素的选择器
                        ]
                    ]
                });

                table.on('tool(test)',
                    function (obj) { //注：tool 是工具条事件名，test 是 table 原始容器的属性 lay-filter=""对应的值""
                        var data = obj.data; //获得当前行数据
                        var layEvent = obj.event; //获得 lay-event 对应的值（也可以是表头的 event 参数对应的值）
                        var tr = obj.tr; //获得当前行 tr 的 DOM 对象（如果有的话）

                        if (layEvent === 'applylive') { //查");
                WriteLiteral(@"看
                            $.ajax({
                                url: '../miniprogram/applylive',
                                type: 'get',
                                data: { ""authorizerAppId"": data[""authorizer_appid""] },
                                dataType: 'json',
                                success: function (res) {
                                    layer.msg(res.result,
                                        {
                                            icon: 2,
                                            time: false,
                                            btn: ['关闭']
                                        });
                                },
                                error: function () {
                                    layer.alert('服务器异常');
                                }
                            });
                        }
                    });
            });


    </script>

    <script type=""text/html"" id=""barDemo"">
      ");
                WriteLiteral("  <a class=\"layui-btn layui-btn-xs\" lay-event=\"applylive\">开通直播</a>\r\n    </script>\r\n    <script type=\"text/html\" id=\"imgTemp\">\r\n        <img src=\"{{d.head_img}}\" style=\"height:48px;width:48px;line-height:48px!important;\" />\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedResultDto<AuthorizerDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
