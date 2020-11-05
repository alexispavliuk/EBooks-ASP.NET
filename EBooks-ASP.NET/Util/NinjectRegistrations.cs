using BLL.Interfaces;
using BLL.Services;
using Ninject.Modules;

namespace EBooks_ASP.NET.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<INewsService>().To<NewsService>();
            Bind<IReviewService>().To<ReviewService>();
            Bind<IPollResultService>().To<PollResultService>();
        }
    }
}