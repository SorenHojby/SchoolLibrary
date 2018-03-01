using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Teacher : Person
    {
        public string OfficeHours { get; set; }

        public override float AverageGrade()
        {
            var avgGrade = 65.67f;
            return avgGrade;
        }
    }
}
