﻿using System.Collections.Generic;
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
                new Video { Id = 1, GenreId = 1, Title = "Shreck"},
                new Video { Id = 2, GenreId = 1, Title = "Despicable Me"},
                new Video { Id = 1, GenreId = 5, Title = "Megamind"},
            };
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