#pragma checksum "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636717ede1a49c5243d4aa57664b21e1d2d5fdc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReportInfo_Edit), @"mvc.1.0.view", @"/Views/ReportInfo/Edit.cshtml")]
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
#line 1 "D:\Projects\BakReport\src\Bak.Report.Web\Views\_ViewImports.cshtml"
using Bak.Report.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\BakReport\src\Bak.Report.Web\Views\_ViewImports.cshtml"
using Volo.Abp.Application.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\BakReport\src\Bak.Report.Web\Views\_ViewImports.cshtml"
using Bak.Report.Application.Contracts.Reports;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636717ede1a49c5243d4aa57664b21e1d2d5fdc8", @"/Views/ReportInfo/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6abdc9c48bc1cf4e5916c940a0753855ac02b50", @"/Views/_ViewImports.cshtml")]
    public class Views_ReportInfo_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReportInfoDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/css/layui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/1.9.1/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/layui/layui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "636717ede1a49c5243d4aa57664b21e1d2d5fdc85843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636717ede1a49c5243d4aa57664b21e1d2d5fdc86957", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 189, "\"", 206, 1);
#nullable restore
#line 7 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
WriteAttributeValue("", 197, Model.Id, 197, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">????????????</label>\r\n        <div class=\"layui-input-inline\">\r\n            <input type=\"text\" name=\"Name\"");
                BeginWriteAttribute("required", " required=\"", 383, "\"", 394, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 395, "\"", 414, 1);
#nullable restore
#line 11 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
WriteAttributeValue("", 403, Model.Name, 403, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" lay-verify=\"required\" placeholder=\"?????????????????????\" autocomplete=\"off\" class=\"layui-input\">\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">??????</label>\r\n        <div class=\"layui-input-block\">\r\n            ");
#nullable restore
#line 17 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
       Write(Html.DropDownList("CategoryId", ViewData["Category"] as SelectList));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""layui-form-item layui-form-text"">
        <label class=""layui-form-label"">??????</label>
        <div class=""layui-input-block"">
            <textarea name=""Introduction"" placeholder=""???????????????"" class=""layui-textarea"">");
#nullable restore
#line 23 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
                                                                                Write(Model.Introduction);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"layui-form-item layui-form-text\">\r\n        <label class=\"layui-form-label\">??????</label>\r\n        <div class=\"layui-input-block\">\r\n");
                WriteLiteral("            <textarea id=\"description\" name=\"Description\" style=\"display: none;\">");
#nullable restore
#line 31 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
                                                                            Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button type=""button"" class=""layui-btn"" id=""btnDocUpload""><i class=""layui-icon"">???</i>????????????</button>
            <input type=""text"" id=""docUri"" name=""DocUri""");
                BeginWriteAttribute("value", " value=\"", 1715, "\"", 1736, 1);
#nullable restore
#line 37 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
WriteAttributeValue("", 1723, Model.DocUri, 1723, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled=""disabled"" style=""border: 0; background-color: #FFF; width: 300px;"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button type=""button"" class=""layui-btn"" id=""btnImgUpload"">???????????????</button>
");
                WriteLiteral("            <blockquote class=\"layui-elem-quote layui-quote-nm\" style=\"margin-top: 10px;\">\r\n                ????????????\r\n                <div class=\"layui-upload-list\" id=\"images\">\r\n");
#nullable restore
#line 47 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
                      
                        foreach (var image in Model.Images)
                        {
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <img");
                BeginWriteAttribute("src", " src=\"", 2605, "\"", 2621, 1);
#nullable restore
#line 52 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
WriteAttributeValue("", 2611, image.Uri, 2611, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2622, "\"", 2628, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"layui-upload-img\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2654, "\"", 2684, 3);
                WriteAttributeValue("", 2664, "preImg(\'", 2664, 8, true);
#nullable restore
#line 52 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
WriteAttributeValue("", 2672, image.Uri, 2672, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2682, "\')", 2682, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 53 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </blockquote>\r\n        </div>\r\n    </div>\r\n    <div class=\"layui-form-item\">\r\n        <div class=\"layui-input-block\">\r\n            <button class=\"layui-btn\"");
                BeginWriteAttribute("lay-submit", " lay-submit=\"", 2932, "\"", 2945, 0);
                EndWriteAttribute();
                WriteLiteral(" lay-filter=\"btn\">??????</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636717ede1a49c5243d4aa57664b21e1d2d5fdc814446", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "636717ede1a49c5243d4aa57664b21e1d2d5fdc815486", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    layui.use('form',
        function () {
            var form = layui.form;

            //????????????
            form.on('submit(btn)',
                function (data) {
                    //???????????????
                    var description = layedit.getContent(index);
                    data.field.Description = description;
                    //????????????
                    var images = [];
                    $('#images').find('img').each(function (i, ele) {
                        var image = {};
                        image.Sort = i;
                        image.Uri = $(ele).attr('src');
                        images.push(image);
                    });
                    data.field.Images = images;
                    $.ajax({
                        url: 'Edit',
                        type: 'post',
                        data: JSON.stringify(data.field),
                        dataType: 'json',
                        contentType: 'application/json;charset=UTF-8',
       ");
            WriteLiteral(@"                 success: function (res) {
                            if (res.code == '0') {
                                parent.layer.close(parent.layer.index);
                            }
                            else {
                                layer.msg('????????????', { icon: 2, time: 2000 });
                            }
                        },
                        error:
                            function () {
                                layer.msg('???????????????', { icon: 2, time: 1500 });
                            }
                    });

                    return false;
                });
        });
</script>
<script>
    layui.use('upload',
        function () {
            var $ = layui.jquery, upload = layui.upload;

            //???????????????
            upload.render({
                elem: '#btnImgUpload',
                url: 'UploadImage', //??????????????????????????????
                //auto:false,
                multiple: true,
                //before: function (obj");
            WriteLiteral(@") {
                //    //????????????????????????????????????ie8
                //    obj.preview(function (index, file, result) {
                //        $('#demo2').append('<img src=""' + result + '"" alt=""' + file.name + '"" class=""layui-upload-img"">')
                //    });
                //},
                done: function (res) {
                    //????????????
                    $('#images').append('<img src=""' + res.message + '"" alt="""" class=""layui-upload-img"" onclick=""preImg(' + '\'' + res.message + '\'' + ')"">');
                }
            });

            //?????????????????????????????????
            upload.render({
                elem: '#btnDocUpload',
                url: 'UploadDoc' //??????????????????????????????
                ,
                accept: 'file', //????????????
                done: function (res) {
                    $(""#docUri"").val(res.message);
                }
            });
        });

    function preImg(uri) {
        layer.open({
            type: 1,
            title: false,
            closeBtn: 0,");
            WriteLiteral(@"
            area: ['auto'],
            skin: 'layui-layer-nobg', //???????????????
            shadeClose: true,
            content: '<div>' +
                ' <img src=""' + uri + '"" style=""max-width: 100%;"">' +
                ' </div>'
        });
    }
</script>
<script>
    var layedit, index;
    layui.use('layedit', function () {
        layedit = layui.layedit;
        index = layedit.build('description'); //???????????????
    });
    //layedit.setContent(index, '");
#nullable restore
#line 172 "D:\Projects\BakReport\src\Bak.Report.Web\Views\ReportInfo\Edit.cshtml"
                            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n</script>\r\n<style>\r\n    .layui-upload-img {\r\n        width: 92px;\r\n        height: 92px;\r\n        margin: 0 10px 10px 0;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReportInfoDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
