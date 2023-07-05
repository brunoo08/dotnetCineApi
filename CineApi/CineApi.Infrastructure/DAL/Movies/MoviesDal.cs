using CineApi.Core.Model.Movies.Result;

namespace CineApi.Infrastructure.DAL.Movies
{
    public class MoviesDal : IMoviesDal
    {
        public async Task<IEnumerable<MoviesResultModel>> GetMoviesCartaz()
        {
            return new MoviesResultModel[0];
        }
    }
}
