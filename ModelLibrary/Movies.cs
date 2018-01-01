using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary
{
    public class Movies
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public double Rating { get; set; }

        public Movies()
        {

        }

        public Movies(int id, string titel, double rating)
        {
            Id = id;
            Titel = Titel;
            Rating = rating;

        }

        public override string ToString()
        {
            //return $"Id: {Id}, Titel: {Titel}, Rating: {Rating}";
            return $"{nameof(Id)}: {Id}, {nameof(Titel)}: {Titel}, {nameof(Rating)}: {Rating}";
        }
    }
}
