using MicroFeedReader.Models;

namespace MicroFeedReader.Data
{
    public class BuiltInFeedData
    {
        public static BuiltInFeed[] Feeds
        {
            get
            {
                return
                [
                new BuiltInFeed()
                {
                    Id = 1,
                    FeedName = "Sky Sports RSS Feed",
                    FeedUrl = "https://www.skysports.com/rss/12040"
                },
                    new BuiltInFeed()
                    {
                        Id = 2,
                        FeedName = "Sporting News RSS Feed",
                        FeedUrl = "https://www.sportingnews.com/us/rss"
                    },
                    new BuiltInFeed()
                    {
                        Id = 3,
                        FeedName = "Pro Sports Outlook",
                        FeedUrl = "https://prosportsoutlook.com/feed/"
                    },
                    new BuiltInFeed()
                    {
                        Id = 4,
                        FeedName = "Sideline Sources",
                        FeedUrl = "https://sidelinesources.com/feed/"
                    }
                ];
            }
        }
    }
}
