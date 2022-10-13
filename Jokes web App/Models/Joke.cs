namespace Jokes_web_App.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string jokeQuestion  { get; set; }

        public int jokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
