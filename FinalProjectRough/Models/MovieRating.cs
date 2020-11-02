using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectRough.Models
{
    public class MovieRating
    {
        // Scalar Properties

        public int MovieRatingID { get; set; }

        public Enum NumericalRating { get; set; }

        // what is this?
        public Enum ReviewStatus { get; set; }

        public String Review { get; set; }

        // Navigational Properties

        public AppUser AppUser { get; set; }

        public Movie Movie { get; set; }
    }
}
