﻿namespace MicroFeedReader.Parser
{
    using System.Xml.Linq;
    using Feeds;
    using MicroFeedReader.Models;

    internal class Rss10Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rdf = feedDoc.Root;
            var channel = rdf.GetElement("channel");
            Rss10Feed feed = new Rss10Feed(feedXml, channel);
            return feed;
        }
    }
}