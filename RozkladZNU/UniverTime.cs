using System;
using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає час початку та кінця пар
     * 
     * {"id": 1, "num": 1, "time_end": "09:20:00", "time_start": "08:00:00"}
     * */
    public class UniverTime
    {
        public int id { get; set; }
        public int num { get; set; }
        public string time_end { get; set; }
        public string time_start { get; set; }
        public DateTime dt_time_end;
        public DateTime dt_time_start;
    }

    public class Times
    {
        public List<UniverTime> objects { get; set; }
    }
}
