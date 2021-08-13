using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VittighedsMaskinenOpgave
{
    public class JokeCategories
    {
        /// <summary>
        /// Returns a list of all jokes in Danish
        /// </summary>
        /// <returns></returns>
        public List<string> AllCategoriesDK()
        {
            List<string> list = new List<string>();

            foreach (string item in Library.KnockKnockJokesDK())
            {
                list.Add(item);
            }

            foreach(string item in Library.DadJokesDK())
            {
                list.Add(item);
            }

            foreach(string item in Library.BlondJokesDK())
            {
                list.Add(item);   
            }

            foreach(string item in Library.YourMomJokesDK())
            {
                list.Add(item);
            }

            return list;
        }
        
        /// <summary>
        /// Returns a list of all jokes in English
        /// </summary>
        /// <returns></returns>
        public List<string> AllCategoriesENG()
        {
            List<string> list = new List<string>();

            foreach (string item in Library.KnockKnockJokesENG())
            {
                list.Add(item);
            }

            foreach(string item in Library.DadJokesENG())
            {
                list.Add(item);
            }

            foreach(string item in Library.BlondJokesENG())
            {
                list.Add(item);   
            }

            foreach(string item in Library.YourMomJokesENG())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all Dad jokes in Danish
        /// </summary>
        /// <returns></returns>
        public List<string> DadJokesDK()
        {
            List<string> list = new List<string>();

            foreach(string item in Library.DadJokesDK())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all Dad jokes in English
        /// </summary>
        /// <returns></returns>
        public List<string> DadJokesENG()
        {
            List<string> list = new List<string>();

            foreach (string item in Library.DadJokesENG())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all Your Mom jokes in Danish
        /// </summary>
        /// <returns></returns>
        public List<string> YourMomJokesDK()
        {
            List<string> list = new List<string>();

            foreach (string item in Library.YourMomJokesDK())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all your mom jokes in English
        /// </summary>
        /// <returns></returns>
        public List<string> YourMomJokesENG()
        {
            List<string> list = new List<string>();

            foreach (string item in Library.YourMomJokesENG())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all Blonde Jokes in Danish
        /// </summary>
        /// <returns></returns>
        public List<string> BlondeJokesDK()
        {
            List<string> list = new List<string>();


            foreach (string item in Library.BlondJokesDK())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all Blonde jokes in English
        /// </summary>
        /// <returns></returns>
        public List<string> BlondeJokesENG()
        {
            List<string> list = new List<string>();


            foreach (string item in Library.BlondJokesENG())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all knock knock jokes in Danish
        /// </summary>
        /// <returns></returns>
        public List<string> KnockKnockJokesDK()
        {
            List<string> list = new List<string>();


            foreach (string item in Library.KnockKnockJokesDK())
            {
                list.Add(item);
            }

            return list;
        }

        /// <summary>
        /// Returns a list of all knock knock jokes in English
        /// </summary>
        /// <returns></returns>
        public List<string> KnockKnockJokesENG()
        {
            List<string> list = new List<string>();


            foreach (string item in Library.KnockKnockJokesENG())
            {
                list.Add(item);
            }

            return list;
        }


    }
}
