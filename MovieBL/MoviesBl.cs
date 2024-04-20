using MovieListModel;

namespace MovieBL
{
    public class MoviesBl
    {
        public List<Listahan> movies = new List<Listahan>();

        public void AddMovie(Listahan movie)
        {
            movies.Add(movie);
        }

        public List<Listahan> GetMovies()
        {
            return movies;
        }
    }
}
