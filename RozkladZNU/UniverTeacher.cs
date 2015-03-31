using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає список всіх викладачів
     * 
     * {"id": 28, "last_update": 1426103281, "name": "Єрмолаєв В.А."}
    */
    public class UniverTeacher
    {
        public int id { get; set; }
        public int last_update { get; set; }
        public string name { get; set; }
    }

    public class Teachers
    {
        public List<UniverTeacher> objects { get; set; }
    }
}
