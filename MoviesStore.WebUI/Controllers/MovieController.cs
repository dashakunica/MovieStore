
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Domain.Abstract;
using MovieStore.Domain.Entities;

namespace MovieStore.WebUI.Controllers
{
    public class MovieController : Controller
    {
        private IMovieRepository repository;
        public MovieController(IMovieRepository repo)
        {
            repository = repo;
        }

        public ViewResult List()
        {
            return View(repository.Movies);
        }
    }
}