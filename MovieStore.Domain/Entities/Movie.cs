using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Domain.Entities
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

}
