﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace REST_WCF_TEMPLATE
{
    public class Movies
    {
        public int Id { get; set; }
        public String Titel { get; set; }
        public double Rating { get; set; }


        // Altid have en default constructor
        public Movies()
        {
        }

        public Movies(int id, string titel, double rating)
        {
            Id = id;
            Titel = titel;
            Rating = rating;
        }

        public override string ToString()
        {

            return $"{nameof(Id)}: {Id}, {nameof(Titel)}: {Titel}, {nameof(Rating)}: {Rating}";
        }
    }
}