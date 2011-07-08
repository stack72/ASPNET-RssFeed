using System.ServiceModel.Syndication;
using System.Web.Mvc;

namespace RssFeed.Controllers
{
    public class RssController : Controller
    {
        //
        // GET: /Rss/

        public ActionResult Feed()
        {
            return new Utils.RssFeed(new SyndicationFeed());
        }

    }
}
