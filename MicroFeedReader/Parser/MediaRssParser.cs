namespace MicroFeedReader.Parser
{
    using System.Xml.Linq;
    using Feeds;
    using MicroFeedReader.Models;

    internal class MediaRssParser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            MediaRssFeed feed = new MediaRssFeed(feedXml, channel);
            return feed;
        }
    }
}