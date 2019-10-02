using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChuckNorrisJokesLibrary
{
   public class JokeGenerator
    {
        //public string GetRandomJoke()
        public async Task<string> randomJoke()
        {
             
            HttpClient client = new HttpClient();
            string randomJoke = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");
            
           var joke = JsonConvert.DeserializeObject< Joke >(randomJokeString
               
               )

                return randomJoke;
        }
        public async Task<string[]> Categories()
        {

            HttpClient client = new HttpClient();
            string categoryString = await client.GetStringAsync("https://api.chucknorris.io/jokes/categories");

            var categories = JsonConvert.DeserializeObject<string[]>(categoryString);
            return categories;


        }


    }


}
