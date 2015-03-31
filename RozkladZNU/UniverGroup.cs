using System.Collections.Generic;
namespace RozkladZNU
{
    /*
     * 
     * Повертає список всіх груп, факультет кожної та timestamp останнього оновлення
     * 
     * {"course": 3, "department_id": 3, "id": 23, "last_update": 1427636604, "name": "2332-н/п", "subgroup_count": 0}
    */
    public class UniverGroup
    {
        public int course { get; set; }
        public int department_id { get; set; }
        public int id { get; set; }
        public int last_update { get; set; }
        public string name { get; set; }
        public int subgroup_count { get; set; }
    }
    public class Groups
    {
        public List<UniverGroup> objects { get; set; }
    }
}
