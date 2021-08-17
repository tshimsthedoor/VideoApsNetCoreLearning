using VideoAsp.Models;

namespace VideoAsp.Entities
{
    public class Video
    {
        public int Id { get; set; }
        public string   Title { get; set; }
        public Genres Genre { get; set; }

    }
}
