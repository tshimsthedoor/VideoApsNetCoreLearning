using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoAsp.Entities;

namespace VideoAsp.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
        Video Get(int id);
    }
}
