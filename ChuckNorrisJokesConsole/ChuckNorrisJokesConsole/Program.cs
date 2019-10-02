using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;

namespace ChuckNorrisJokesConsole
{
    class Program
    {
        static async  Task Main(string[] args)

        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string[] randomJoke = await jokeGenerator.Categories();

            Console.WriteLine(randomJoke);

            string[] categories = await jokeGenerator.Categories();
            for (int index = 0; index < categories.Length; index++)
        }
    }
}
