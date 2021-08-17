using System.ComponentModel.DataAnnotations;
using VideoAsp.Models;

namespace VideoAsp.ViewModels
{
    public class VideoEditViewModel
    {
        public int Id { get; set; }
        [Required, MinLength(3)]
        public string Title { get; set; }
        [Required]
        public Genres Genre { get; set; }
    }
}
