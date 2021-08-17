using System.Diagnostics;
using System.Linq;
using VideoAsp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using VideoAsp.Models;
using VideoAsp.Services;
using System;

namespace VideoAsp.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        private IVideoData _videos;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(video =>
                new VideoViewModel
                {
                    Id = video.Id,
                    Title = video.Title,
                    Genre = video.Genre.ToString()
                }); ;
            return View(model);
        }

        public IActionResult Details(int  id)
        {
            var model = _videos.Get(id);

            if (model == null) return RedirectToAction("Index");

            return View(new VideoViewModel
            {
                Id = model.Id,
                Title = model.Title,
                Genre = model.Genre.ToString()
            });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(VideoEditViewModel model)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
