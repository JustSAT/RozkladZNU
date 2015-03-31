using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає список всіх корпусів
     * 
     * {"id": 1, "last_update": 1423907539, "latitude": 47.819116, "longitude": 35.18341, "name": "1 корпус", "resource_uri": "/api/v1/campus/1/"}
     */

    public class UniverCampus
    {
        public int id { get; set; }
        public int last_update { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string name { get; set; }
        public string resource_uri { get; set; }
    }

    public class Campuses
    {
        public List<UniverCampus> objects { get; set; }
    }
}
