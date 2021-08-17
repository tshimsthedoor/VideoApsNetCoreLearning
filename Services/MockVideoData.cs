using System.Collections.Generic;
using System.Linq;
using VideoAsp.Entities;

namespace VideoAsp.Services
{
    public class MockVideoData : IVideoData
    {
        private List<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Genre = Models.Genres.Animated, Title = "Shreck"},
                new Video { Id = 2, Genre = Models.Genres.Animated, Title = "Despicable Me"},
                new Video { Id = 1, Genre = Models.Genres.Action, Title = "Megamind"},
            };
        }

        public void Add(Video newVideo)
        {
            newVideo.Id = _videos.Max(v => v.Id) + 1;
            _videos.Add(newVideo);
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(V => V.Id.Equals(id));
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }

        

       
    }
}
