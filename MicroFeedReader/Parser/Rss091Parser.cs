namespace MicroFeedReader.Parser
{
    using System.Xml.Linq;
    using Feeds;
    using MicroFeedReader.Models;

    internal class Rss091Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss091Feed feed = new Rss091Feed(feedXml, channel);
            return feed;
        }
    }
}
