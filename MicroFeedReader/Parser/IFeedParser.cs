using MicroFeedReader.Feeds;

namespace MicroFeedReader.Parser
{
    internal interface IFeedParser
    {
        BaseFeed Parse(string feedXml);
    }
}
