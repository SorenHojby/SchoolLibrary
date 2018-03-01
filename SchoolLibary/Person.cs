using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public abstract float AverageGrade();

        public virtual string SendMessage(string message)
        {
            DateTime dt = new DateTime();
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("Message send on {0} at {1}", dt.Day, dt.TimeOfDay));
            result.AppendLine(message);
            return result.ToString();

        }
    }
}
