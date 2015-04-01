using System.Collections.Generic;

namespace RozkladZNU
{
    /*
     * 
     * Повертає інформацію про поточний тиждень та поточний тиждень на сервері.
     * 1 – чисельник
     * 2 – знаменник
     * 
     * {"timetable_week": 1, "year_week": 14}
     */
    public class UniverCurrentWeek
    {
        public int timetable_week { get; set; }
        public int year_week { get; set; }
    }
}
