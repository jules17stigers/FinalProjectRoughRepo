using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectRough.Models
{
    public class Movie
    {
        // Scalar Properties
        
        public int MovieID { get; set; }

        public String Title { get; set; }

        public String Tagline { get; set; }

        public Enum MPAARating { get; set; }

        public DateTime ReleaseYear { get; set; }

        public String Overview { get; set; }
        
        public int Runtime { get; set; }
        
        public String Actor { get; set; }

        public Decimal AvgRating { get; set; }

        // Navigational Properties

        public List<MovieRating> MovieRatings { get; set; }

        public List<Showing> Showings { get; set; }
    }
}
