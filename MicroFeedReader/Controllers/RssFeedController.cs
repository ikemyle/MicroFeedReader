using MicroFeedReader.Data;
using MicroFeedReader.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroFeedReader.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RssFeedController(ILogger<RssFeedController> logger) : ControllerBase
    {
        private readonly ILogger<RssFeedController> _logger = logger;
        private readonly IEnumerable<BuiltInFeed> Feeds = BuiltInFeedData.Feeds;

        [Route("BuiltInFeeds")]
        [HttpGet]
        public IEnumerable<BuiltInFeed> BuiltInFeeds()
        {
            return Feeds;
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var feedUrl = Feeds.Where(f => f.Id == id).FirstOrDefault()?.FeedUrl;
            if (feedUrl != null)
            {
                var readerTask = await FeedReader.ReadAsync(feedUrl);
                var feedItems = readerTask.Items;
                return Ok(feedItems);
            }
            else
            {
                return NotFound();
            }
        }

        [Route("FeedFromUrl")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            if (value != null)
            {
                var readerTask = await FeedReader.ReadAsync(value);
                var feedItems = readerTask.Items;
                return Ok(feedItems);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
