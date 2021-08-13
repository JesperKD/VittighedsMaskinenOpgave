using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VittighedsMaskinenOpgave
{
    public class JokeProvider
    {
        private JokeCategories JokeCategories = new JokeCategories();

        /// <summary>
        /// Returns a random joke of any category
        /// </summary>
        /// <returns></returns>
        public Joke GetRandomJoke()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.AllCategoriesDK().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.AllCategoriesDK()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random danish dad Joke
        /// </summary>
        /// <returns></returns>
        public Joke GetDadJokeDK()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.DadJokesDK().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.DadJokesDK()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random english dad joke
        /// </summary>
        /// <returns></returns>
        public Joke GetDadJokeENG()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.DadJokesENG().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.DadJokesENG()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random danish your mom joke
        /// </summary>
        /// <returns></returns>
        public Joke GetYourMomJokeDK()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.YourMomJokesDK().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.YourMomJokesDK()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// returns random english your mom joke
        /// </summary>
        /// <returns></returns>
        public Joke GetYourMomJokeENG()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.YourMomJokesENG().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.YourMomJokesENG()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random danish blonde joke
        /// </summary>
        /// <returns></returns>
        public Joke GetBlondeJokeDK()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.BlondeJokesDK().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.BlondeJokesDK()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random english blonde joke
        /// </summary>
        /// <returns></returns>
        public Joke GetBlondeJokeENG()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.BlondeJokesENG().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.BlondeJokesENG()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random danish knock knock joke
        /// </summary>
        /// <returns></returns>
        public Joke GetKnockKnockJokeDK()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.KnockKnockJokesDK().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.KnockKnockJokesDK()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }

        /// <summary>
        /// Returns random english knock knock joke
        /// </summary>
        /// <returns></returns>
        public Joke GetKnockKnockJokeENG()
        {
            Random random = new Random();
            List<Joke> jokes = new List<Joke>();

            for (int i = 0; i < JokeCategories.KnockKnockJokesENG().Count(); i++)
            {
                Joke joke = new Joke(JokeCategories.KnockKnockJokesENG()[i]);
                jokes.Add(joke);
            }

            return jokes[random.Next(0, jokes.Count())];
        }
    }
}
