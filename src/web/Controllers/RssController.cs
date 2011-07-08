using System;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web.Mvc;
using RssFeed.Models;
using RssFeed.Utils;

namespace RssFeed.Controllers
{
    public class RssController : Controller
    {
        private readonly IRepositoryLayer _repositoryLayer;
        public RssController(IRepositoryLayer repositoryLayer)
        {
            _repositoryLayer = repositoryLayer;
        }
        //
        // GET: /Rss/

        public ActionResult Feed()
        {
            var posts = _repositoryLayer.GetAll();

            var syndicateFeed = BuildFeedStaticData();
            syndicateFeed.Items = posts.Select(BuildSyndicateItem).ToList();

            return new RssFeedResult(syndicateFeed);
        }

        private static SyndicationItem BuildSyndicateItem(Article post)
        {
            throw new NotImplementedException();
        }

        private static SyndicationFeed BuildFeedStaticData()
        {
            throw new NotImplementedException();
        }
    }
}
