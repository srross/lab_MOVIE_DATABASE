using lab_MOVIE_DATABASE;

List<Movie> movieList = new List<Movie>();
{
    new Movie("Action", "Black Panther");
    new Movie("Comedy", "Madea Homecoming");
    new Movie("Sci-Fi", "The Matrix Reloaded");
    new Movie("Action", "Avatar");
    new Movie("Adventure", "Black Panther");
    new Movie("Adventure", "The Lion King");
    new Movie("Action", "Moana");
    new Movie("Drama", "Mahogany");
    new Movie("Comedy", "he Water Boy");
    new Movie("Action", "Black Panther");
}

Console.WriteLine("Entr a category: action comedy sci-fi adventure drama");

var userInput = Console.ReadLine();

List<Movie> selectedList = movieList.Where(x => x.GetCategory() == userInput).ToList());

foreach(Movie movie in selectedList)
{
    Console.WriteLine(movie.GetTitle);
}