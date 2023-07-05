using CineApi.Core.Model.Movies.Result;

namespace CineApi.Infrastructure.DAL.Movies
{
    public interface IMoviesDal
    {
        /// <summary>
        /// Get Movies Cartaz
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MoviesResultModel>> GetMoviesCartaz();
    }
}
