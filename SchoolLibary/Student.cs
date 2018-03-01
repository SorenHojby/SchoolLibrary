using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum DegreePrograms {
            MultimediaDesign,
            WebDevelopment,
            ComputerScience,
            DConcept
        }
       public DegreePrograms DegreeProgram { get; set; }

        public override float AverageGrade()
        {
            // TODO: do the actial math and calculate average
            var avgGrade = 7.67f;
            return avgGrade;
        }
        public override string SendMessage(string message)
        {
            var original = base.SendMessage(message);
            var sb = new StringBuilder(original);
            sb.AppendLine("This message confidential and private.");
                return sb.ToString();

        }
    }
}
