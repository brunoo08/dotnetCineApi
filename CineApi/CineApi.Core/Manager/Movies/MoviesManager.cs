using CineApi.Core.Model;

namespace CineApi.Core.Manager.Movies
{
    public class MoviesManager : IMoviesManager
    {
		private readonly IMoviesDal _moviesDAL;

        public Task<ResultModel> GetMoviesCartaz()
        {
			try
			{
				var result = 
			}
			catch (Exception ex)
			{

				throw;
			}
        }
    }
}
