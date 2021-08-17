using System.Collections.Generic;
using VideoAsp.Entities;

namespace VideoAsp.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
        Video Get(int id);
        void Add(Video newVideo);
    }
}
