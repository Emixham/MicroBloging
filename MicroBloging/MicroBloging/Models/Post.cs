using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MicroBloging.Models
{
    public class Post
    {
        public string Text { get; set; }
        public int [] Reaction { get; set; }
    }
}