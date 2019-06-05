using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_test.Models
{
    public class Article
    {
        public int ArticleId { get; set; }
        public byte[] Photo1 { get; set; }
        public byte[] Photo2 { get; set; }
        public byte[] Photo3 { get; set; }
        public byte[] Photo4 { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }


        public ICollection<Basket> Basket;
    }
}