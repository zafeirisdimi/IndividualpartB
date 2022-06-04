﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Models
{
    public class Course : ISimpleModel
    {
        public  int CourseId { get; set; }

        public string Name { get; set; }
        public string  Description { get; set; }

        public int TotalHours { get; set; }
        public string Website { get ; set ; }
    }
}
