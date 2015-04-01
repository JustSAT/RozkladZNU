using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає список всіх предметів
     * 
     * {"id": 88, "last_update": 1426069514, "name": "Web-технології програмування"}
     * */
    public class UniverLesson
    {
        public int id { get; set; }
        public string last_update { get; set; }
        public string name { get; set; }
    }

    public class Lessons
    {
        public List<UniverLesson> objects { get; set; }
    }
}
