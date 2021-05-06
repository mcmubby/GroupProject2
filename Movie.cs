namespace GroupProject2
{
    public class Movie
    {
        public string _title { get; private set; }
        public string _studio { get; private set; }
        public string _rating { get; private set; }


        public Movie(string movieTitle, string studioMovieWasMade, string movieRating)
        {
            this._title = movieTitle;
            this._studio = studioMovieWasMade;
            this._rating = movieRating;
        }

        public Movie(string movieTitle, string studioMovieWasMade)
        {
            this._title = movieTitle;
            this._studio = studioMovieWasMade;
            this._rating = "PG";
        }

        public Movie[] getPG(Movie[] movies)
        {
            Movie[] pgMovies = new Movie[movies.Length];
            int count = 1;
            
            foreach (var movie in movies)
            {
                if (movie._rating.ToUpper() == "PG")
                {
                    pgMovies[count-1] = movie;
                    count++;
                }
            }

            return pgMovies;
        }

        public static Movie CasinoRoyale()
        {
            return new Movie("Casino Royale", "Eon Productions", "PG13");
        }
    }
}