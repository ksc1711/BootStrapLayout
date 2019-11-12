using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapLayout.Startup))]
namespace BootStrapLayout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            GetCommonCode();//공통코드 불러오기
        }
        /// <summary>
        /// 공통코드 메모리에 올리기
        /// </summary>
        public void GetCommonCode()
        {
            //BootStrapLayout.Common.BizCommon bizCommon = new Business.Common.BizCommon();
            //BootStrapLayout.Common.staticCommonCode.listCommonCodeInfo = bizCommon.GetCommonCodeList();
        }
    }
}
