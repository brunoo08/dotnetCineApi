using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CineApi.Core.Model;

namespace CineApi.Core.Manager.Movies
{
    public interface IMoviesManager
    {
        /// <summary>
        /// Get Movies Cartaz
        /// </summary>
        /// <returns></returns>
        Task<ResultModel> GetMoviesCartaz();
    }
}
