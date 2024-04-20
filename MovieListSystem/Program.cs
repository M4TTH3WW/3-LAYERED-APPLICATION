using MovieListModel;
using MovieBL;
using MovieDataLayer;

namespace MovieListSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username Account:");
            string user = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            Movie loginAccount = new Movie();
            bool result = loginAccount.VerifyUsername(user, password);

            if (result)
            {
                Console.WriteLine("<3 Welcome to Netflix <3 ");
                Console.WriteLine("Top 10 Movies:)");
                Console.WriteLine("Choose a movie to see the info:");
                Console.WriteLine("1.The Notebook");
                Console.WriteLine("2.Forrest Gump");
                Console.WriteLine("3.The Green Mile");
                Console.WriteLine("4.The Platform");
                Console.WriteLine("5.Rewind");
                Console.WriteLine("6.Avengers:Endgame");
                Console.WriteLine("7.Shaolin Soccer");
                Console.WriteLine("8.Man in Love");
                Console.WriteLine("9.The Hobbit:An Unexpected Journey");
                Console.WriteLine("10.Train to Busan");

                Movie show = new Movie();
                int moviechoices = Convert.ToInt32(Console.ReadLine());
                switch (moviechoices)
                {
                    case 1:
                        Console.WriteLine("Movie Title: The Notebook");
                        Console.WriteLine("Director: Nick Cassavetes");
                        Console.WriteLine("Genre: Romance, Drama");
                        Console.WriteLine("Duration: 123 mins");
                        Console.WriteLine("Country of Origin: United States of America");
                        Console.WriteLine("Release Date: 2004-06-25");
                        break;
                    case 2:
                        Console.WriteLine("Movie Title: Forrest Gump");
                        Console.WriteLine("Director: Robert Zemeckis");
                        Console.WriteLine("Genre: Comedy, Romance, Drama");
                        Console.WriteLine("Duration: 142 mins");
                        Console.WriteLine("Country of Origin: United States of America");
                        Console.WriteLine("Release Date: 1994-07-06");
                        break;
                    case 3:
                        Console.WriteLine("Movie Title: The Green Mile");
                        Console.WriteLine("Director: Frank Darabont");
                        Console.WriteLine("Genre: Fantasy, Drama, Crime");
                        Console.WriteLine("Duration: 189 mins");
                        Console.WriteLine("Country of Origin: United States of America");
                        Console.WriteLine("Release Date: 1999-12-10");
                        break;
                    case 4:
                        Console.WriteLine("Movie Title: The Platform");
                        Console.WriteLine("Director: Galder Gaztelu-Urrutia");
                        Console.WriteLine("Genre: Horror, Sci-Fi, Thriller");
                        Console.WriteLine("Duration: 94 mins");
                        Console.WriteLine("Country of Origin: Spain");
                        Console.WriteLine("Release Date: 2020-03-20");
                        break;
                    case 5:
                        Console.WriteLine("Movie Title: Rewind");
                        Console.WriteLine("Director: Mae Czarina Cruz");
                        Console.WriteLine("Genre: Drama, Romance, Sci-Fi");
                        Console.WriteLine("Duration: 112 mins");
                        Console.WriteLine("Country of Origin: Philippines");
                        Console.WriteLine("Release Date: 2024-01-04");
                        break;
                    case 6:
                        Console.WriteLine("Movie Title: Avengers: Endgame");
                        Console.WriteLine("Director: Anthony Russo, Joe Russo");
                        Console.WriteLine("Genre: Action, Adventure, Drama, Sci-Fi");
                        Console.WriteLine("Duration: 181 mins");
                        Console.WriteLine("Country of Origin: United States of America");
                        Console.WriteLine("Release Date: 2019-04-26");
                        break;
                    case 7:
                        Console.WriteLine("Movie Title: Shaolin Soccer");
                        Console.WriteLine("Director: Stephen Chow");
                        Console.WriteLine("Genre: Action, Comedy, Fantasy, Sport");
                        Console.WriteLine("Duration: 87 mins");
                        Console.WriteLine("Country of Origin: Hong Kong, China");
                        Console.WriteLine("Release Date: 2001-07-05");
                        break;
                    case 8:
                        Console.WriteLine("Movie Title: Man in Love");
                        Console.WriteLine("Director: Yin Chen-hao");
                        Console.WriteLine("Genre: Drama, Romantic");
                        Console.WriteLine("Duration: 115 mins");
                        Console.WriteLine("Country of Origin: Taiwan");
                        Console.WriteLine("Release Date: 2021-04-01");
                        break;
                    case 9:
                        Console.WriteLine("Movie Title: The Hobbit:An Unexpected Journey");
                        Console.WriteLine("Director: Peter Jackson");
                        Console.WriteLine("Genre: Adventure, Fantasy");
                        Console.WriteLine("Duration: 169 mins");
                        Console.WriteLine("Country of Origin: New Zealand, United States");
                        Console.WriteLine("Release Date: 2012-12-14");
                        break;
                    case 10:
                        Console.WriteLine("Movie Title: Train to Busan");
                        Console.WriteLine("Director: Yeon Sang-ho");
                        Console.WriteLine("Genre: Action, Horror, Thriller");
                        Console.WriteLine("Duration: 118 mins");
                        Console.WriteLine("Country of Origin: South Korea");
                        Console.WriteLine("Release Date: 2016-07-20");
                        break;
                    default:
                        Console.WriteLine("Error:");
                        break;

                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
