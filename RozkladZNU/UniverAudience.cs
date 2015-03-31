using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає список всіх аудиторій
     * 
     * {"audience": "18a", "campus_id": 1, "id": 58, "last_update": 1426079253}
    */

    public class UniverAudience
    {
        public string audience { get; set; }
        public int campus_id { get; set; }
        public int last_update { get; set; }
    }
    public class Audiences
    {
        public List<UniverAudience> objects { get; set; }
    }
}
