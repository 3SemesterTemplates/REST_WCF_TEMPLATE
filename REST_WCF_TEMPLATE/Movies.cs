using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_WCF_TEMPLATE
{
    public class Movies
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public double Rating { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Titel: {Titel}, Rating: {Rating}";
        }
    }
}