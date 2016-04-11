using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QualityWeek_CodingContest_AshutoshS2.Startup))]
namespace QualityWeek_CodingContest_AshutoshS2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
