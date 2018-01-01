using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_WCF_TEMPLATE
{
    //template til eksamen
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        #region STATIC LIST
        public static List<Movies> ListOfMoves { get; } = new List<Movies>
        {
            new Movies {Id = 1, Titel = "Far til 40", Rating= 4},
            new Movies {Id = 2, Titel = "Halløj Her", Rating= 3},
            new Movies {Id = 3, Titel = "Star Wars", Rating= 5}
        };
        #endregion

        #region CONNECTION STRING
        //Connection string
        private static string connectingString =
               "Server=tcp:natascha.database.windows.net,1433;Initial Catalog=School;Persist Security Info=False;User ID=nataschajakobsen;Password=Roskilde4000;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        #endregion

        #region POST U. DB
        public void AddMovie(Movies newMovie)
        {
            ListOfMoves.Add(newMovie);
        }
        #endregion

        #region DELETE U. DB
        public Movies DeleteMovie(int id)
        {
            var deleteMovie = GetOneMovie(id.ToString());
            if (deleteMovie != null)
            {
                ListOfMoves.Remove(deleteMovie);
                return deleteMovie;
            }

            return null;
        }
        #endregion

        #region GET U. DB
        public List<Movies> GetMovies()
        {
            return ListOfMoves;
        }
        #endregion

        #region GET ONE MOVIE U. DB
        public Movies GetOneMovie(string id)
        {
            int idint = Int32.Parse(id);

            return ListOfMoves.Find(c => c.Id == idint);
        }
        #endregion

        #region PUT U. DB
        public Movies UpdateMovie(Movies myMovie)
        {
            var updateMovie = GetOneMovie(myMovie.Id.ToString());
            if (updateMovie != null)
            {
                updateMovie.Id = myMovie.Id;
                updateMovie.Titel = myMovie.Titel;
                updateMovie.Rating = myMovie.Rating;
                return updateMovie;
            }

            return null;
        }
        #endregion
    }
}
