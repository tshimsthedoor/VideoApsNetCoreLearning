using System.ComponentModel.DataAnnotations;
using VideoAsp.Models;

namespace VideoAsp.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string   Title { get; set; }
        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }

    }
}
