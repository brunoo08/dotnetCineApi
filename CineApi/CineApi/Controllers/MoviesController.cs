using CineApi.Core.Manager.Movies;
using Microsoft.AspNetCore.Mvc;

namespace CineApi.Controllers
{
    public class MoviesController : Controller
    {
        #region Properties
        private readonly IMoviesManager _moviesManager;
        #endregion

        #region Constructor
        public MoviesController(IMoviesManager moviesManager)
        {
            _moviesManager = moviesManager;
        }
        #endregion

        #region Index
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region GetMoviesCartaz
        [HttpGet]
        [Route("/GetMoviesCartaz")]
        public async Task<IActionResult> GetMoviesCartaz()
            => Ok(await _moviesManager.GetMoviesCartaz());
        #endregion
    }
}
