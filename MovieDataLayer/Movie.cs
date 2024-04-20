using MovieListModel;
using MovieBL;

namespace MovieDataLayer
{
    public class Movie
    {
        List<Login> Account = new List<Login>();

        public Movie()
        {
            Login Account1 = new Login
            {
                userName = "pascua",
                passWord = "shish",
            };

            Login Account2 = new Login
            {
                userName = "matthew",
                passWord = "salam",
            };

            Login Account3 = new Login
            {
                userName = "alexis",
                passWord = "nonchalant",
            };

            Account.Add(Account1);
            Account.Add(Account2);
            Account.Add(Account3);
        }
        public Login GetLoginAcount(string userName)
        {
            Login foundAccount = new Login();

            foreach (Login login in Account)
            {
                if (login.userName == userName)
                {
                    foundAccount = login;
                }
            }
            return foundAccount;
        }

        public void AddMovies(MoviesBl moviesBl)
        {
            Listahan one = new Listahan
            {
                Title = "The Notebook",
                Director = "Nick Cassavetes",
                Genre = "Romance, Drama",
                Duration = "123 mins",
                CountryOrigin = "United States of America",
                ReleaseDate = "2004-06-25",
            };

            Listahan two = new Listahan
            {
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                Genre = "Comedy, Romance, Drama",
                Duration = "142 mins",
                CountryOrigin = "United States of America",
                ReleaseDate = " 1994-07-06",

            };
            Listahan three = new Listahan
            {
                Title = "The Green Mile",
                Director = "Frank Darabont",
                Genre = "Fantasy, Drama, Crime",
                Duration = "189 mins",
                CountryOrigin = "United States of America",
                ReleaseDate = "1999-12-10",

            };
            Listahan four = new Listahan
            {
                Title = "The Platform",
                Director = "Galder Gaztelu-Urrutia",
                Genre = "Horror, Sci-Fi, Thriller",
                Duration = "94 mins",
                CountryOrigin = "Spain",
                ReleaseDate = "2020-03-20",

            };
            Listahan five = new Listahan
            {
                Title = "Rewind",
                Director = "Mae Czarina Cruz",
                Genre = "Drama, Romance, Sci-Fi",
                Duration = "112 mins",
                CountryOrigin = "Philippines",
                ReleaseDate = "2024-01-04",

            };
            Listahan six = new Listahan
            {
                Title = "Avengers:Endgame",
                Director = "Anthony Russo, Joe Russo",
                Genre = "Action, Adventure, Drama, Sci-Fi",
                Duration = "181 mins",
                CountryOrigin = "United States of America",
                ReleaseDate = "2019-04-26",

            };
            Listahan seven = new Listahan
            {
                Title = "Shaolin Soccer",
                Director = "Stephen Chow",
                Genre = "Action, Comedy, Fantasy, Sport",
                Duration = "87 mins",
                CountryOrigin = "Hongkong, China",
                ReleaseDate = "2001-07-05",

            };
            Listahan eight = new Listahan
            {
                Title = "Man in Love",
                Director = "Yin Chen-hao",
                Genre = "Drama, Romantic",
                Duration = "115 mins",
                CountryOrigin = "Taiwan",
                ReleaseDate = "2021-04-01",

            };
            Listahan nine = new Listahan
            {
                Title = "The Hobbit:An Unexpected Journey",
                Director = "Peter Jackson",
                Genre = "Adventure, Fantasy",
                Duration = "169 mins",
                CountryOrigin = "New Zealand, United States",
                ReleaseDate = "2012-12-14",

            };
            Listahan ten = new Listahan
            {
                Title = "Train to Busan",
                Director = "Yeon Sang-ho",
                Genre = "Action, Horror, Thriller",
                Duration = "118 mins",
                CountryOrigin = "South Korea",
                ReleaseDate = "2016-07-20",

            };


            moviesBl.AddMovie(one);
            moviesBl.AddMovie(two);
            moviesBl.AddMovie(three);
            moviesBl.AddMovie(four);
            moviesBl.AddMovie(five);
            moviesBl.AddMovie(six);
            moviesBl.AddMovie(seven);
            moviesBl.AddMovie(eight);
            moviesBl.AddMovie(nine);
            moviesBl.AddMovie(ten);
        }
        public bool VerifyUsername(string username, string password)
        {
            Movie dataService = new Movie();
            var result = dataService.GetLoginAcount(username);

            return result.userName != null ? true : false;
        }
    }
}
