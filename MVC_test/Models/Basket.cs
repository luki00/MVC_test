using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_test.Models
{
    public class Basket
    {
        public int BasketId { get; set; }
        public virtual Article Article { get; set; }
        public virtual User User { get; set;}
        public bool Accepted { get; set; }

    }
}