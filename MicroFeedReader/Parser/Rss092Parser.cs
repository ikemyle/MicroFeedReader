namespace MicroFeedReader.Parser
{
    using System.Xml.Linq;
    using Feeds;
    using MicroFeedReader.Models;
    internal class Rss092Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss092Feed feed = new Rss092Feed(feedXml, channel);
            return feed;
        }
    }
}
