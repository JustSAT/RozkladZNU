using System;
using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає розклад групи або викладача
     * 
     * {"audience_id": 1, "date_end": "2015-05-30", "date_start": "2015-02-02", "day": 0, "free_trajectory": false, 
     *  "group": [1], "id": 135, "last_update": 1424263813, "lesson_id": 38, "lesson_type": 0, "periodicity": 0, 
     *  "subgroup": 2, "teacher_id": 37, "time_id": 5}
     */
    public class UniverTimetable
    {
        public int audience_id { get; set; }
        public string date_end { get; set; }
        public string date_start { get; set; }
        public int day { get; set; }
        public bool free_trajectory { get; set; }
        public int id { get; set; }
        public string last_update { get; set; }
        public int lesson_id { get; set; }
        public int lesson_type { get; set; }
        public int periodicity { get; set; }
        public int subgroup { get; set; }
        public int teacher_id { get; set; }
        public int time_id { get; set; }
    }
    public class Timetables
    {
        public List<UniverTimetable> objects { get; set; }
    }
}
