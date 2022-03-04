using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_MOVIE_DATABASE
{
    public class Movie
    {
        private string _category; //get/set not needed when private
        private string _title;

        public Movie(string category, string title) 
        {
            this._category = category;  
            this._title = title;
        }

        public string GetCategory()
        {
           return _category;
        }

        public string GetTitle()
        {
            return _title;
        }

    }
}