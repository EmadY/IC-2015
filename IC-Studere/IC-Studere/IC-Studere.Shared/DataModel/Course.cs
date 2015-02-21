using System;
using System.Collections.Generic;
using System.Text;
using Windows.Data.Json;

namespace IC_Studere.DataModel
{
    public class Course
    {
        public string id { get; set; }
        public string department { get; set; }
        public string course_number { get; set; }
        public string Teacher { get; set; }
        public string section { get; set; }
        public string time { get; set; }
        public string location { get; set; }

    }
}