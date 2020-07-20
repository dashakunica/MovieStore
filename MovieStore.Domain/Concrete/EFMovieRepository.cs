using System.Collections.Generic;
using MovieStore.Domain.Entities;
using MovieStore.Domain.Abstract;

namespace MovieStore.Domain.Concrete
{
    public class EFMovieRepository : IMovieRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Movie> Movies
        {
            get { return context.Movies; }
        }
    }
}