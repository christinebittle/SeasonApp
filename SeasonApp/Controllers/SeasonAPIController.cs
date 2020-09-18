using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeasonApp.Models;


namespace SeasonApp.Controllers
{
    public class SeasonAPIController : ApiController
    {

        /// <summary>
        /// Receives an input of the temperature and provides information about the season
        /// </summary>
        /// <param name="temperature">The temperature in degrees C</param>
        /// <example>
        ///     GET api/SeasonAPI/GetSeason/21	->
        ///     ["Summer","Sean O.","https://unsplash.com/photos/KMn4VEeEPR8"]
        /// </example>
        /// <example>
        ///     GET api/SeasonAPI/GetSeason/17	->
        ///     ["Fall","Jeremy Thomas","https://unsplash.com/photos/O6N9RV2rzX8"]
        /// </example>
        /// <example>
        ///     GET api/SeasonAPI/GetSeason/-15	-> 
        ///     ["Winter","Bob Canning","https://unsplash.com/photos/r53rNKb_7s8"]
        /// </example>
        /// <returns>
        ///     The associated season with the temperature,
        ///     The associated photographer for the image we are using,
        ///     The original image URL we are using
        /// </returns>
        [Route("api/SeasonAPI/GetSeason/{temperature}")]
        public Season GetSeason(int? temperature)
        {
            string season = "";
            string author = "";
            string img = "";
            if (temperature == null) {
                season = "unknown";
                author = "unknown";
                img = "unknown";
            }

            if (temperature > 20)
            {
                season = "Summer";
                author = "Sean O.";
                img = "https://unsplash.com/photos/KMn4VEeEPR8";
            }
            else if (temperature >= 15)
            {
                season = "Fall";
                author = "Jeremy Thomas";
                img = "https://unsplash.com/photos/O6N9RV2rzX8";
            }
            else if (temperature > 10)
            {
                season = "Spring";
                author = "Sergey Shmidt";
                img = "https://unsplash.com/photos/koy6FlCCy5s";
            }
            else
            {
                season = "Winter";
                author = "Bob Canning";
                img = "https://unsplash.com/photos/r53rNKb_7s8";
            }

            Season SeasonInfo = new Season();
            SeasonInfo.SeasonName = season;
            SeasonInfo.PhotographerName = author;
            SeasonInfo.ImageURL = img;
            


            return SeasonInfo;
        }
    }
}
