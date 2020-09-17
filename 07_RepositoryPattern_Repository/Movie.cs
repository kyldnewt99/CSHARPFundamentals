using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }
        public Movie() {}

        public Movie(string title, string description, float starRating, string mRating, bool isFamilyFriendly, GenreType tOG, double runTime)
        :base(title, description, starRating,mRating,isFamilyFriendly,tOG)
        {
            RunTime = runTime;
        }
    }
}
