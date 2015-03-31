using System.Collections.Generic;
namespace RozkladZNU
{
    /*
     * 
     * Повертає список всіх факультетів університету та timestamp останнього оновлення
     * 
     * {"id": 3, "last_update": 1427636604, "name": "Факультет іноземної філології"}
    */

    public class UniverDepartment
    {
        public string name { get; set; }
        public int id { get; set; }
        public int last_update { get; set; }
    }

    public class Departments
    {
        public List<UniverDepartment> objects { get; set; }
    }
}