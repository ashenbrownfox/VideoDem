using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideosDemo.Models;

namespace VideosDemo.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movies Movie { get; set; }
        public List<Customer> Customer { get; set;  }
    }
}