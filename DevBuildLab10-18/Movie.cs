using System;
using System.Collections.Generic;
using System.Text;

namespace DevBuildLab10_18
{
    class Movie
    {
        //Properties, Constructor, Methods
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public Movie(string Name, string Category, string Description)
        {
            this.Name = Name;
            this.Category = Category;
            this.Description = Description;
        
        }
    }
}
