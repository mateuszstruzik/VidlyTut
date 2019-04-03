using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyTut.Models;

namespace VidlyTut.ViewModels
{
    public class RandomMovieViewmodel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}