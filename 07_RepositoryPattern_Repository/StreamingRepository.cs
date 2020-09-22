using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepository: StreamingContentRepository
    {
        public Show GetShowByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower()==title.ToLower() && content.GetType()== typeof(Show))
                {
                    //change from of type streaming content to of type show
                    return (Show)content;
                }
            }
            return null;
        }
        public Movie GetMovieByTitle (string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movie))
                {
                    //change from of type streaming content to of type movie
                    return (Movie)content;
                }
            }
            return null;
        }
        public List<Show>GetAllShows()
        {
            //make a space to save all shows
            List<Show> allShows = new List<Show>();
            //pull one item and see if it is a show
            //make sure to save that off to the side
            //return that list
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content is Show)
                {
                    allShows.Add((Show)content);
                }
            }
            //return that list
            return allShows;
        }
        //CHALLENGES:
        //write GetAllMovies
        //GetByOtherParameters ex GetAllFamilyFriendlyMovies
        //Get Shows with over x episodes
        public List<Movie> GetAllMovies()
        {
            //make a space to save all shows
            List<Movie> allMovies = new List<Movie>();
            //pull one item and see if it is a show
            //make sure to save that off to the side
            //return that list
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add((Movie)content);
                }
            }
            //return that list
            return allMovies;
        }
    }
}
