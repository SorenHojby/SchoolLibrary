using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public int ZipCode
        {
            get;
            set;
        }

        public string City
        {
            get;
            set;
        }

        public string Country
        {
            get;
            set;
        }

        public int PhoneNumber
        {
            get;
            set;
        }

        public string Website
        {
            get;
            set;
        }

        public string _twitterHandle;
        public string TwitterHandle
        {
            get { return this._twitterHandle; }
            //Make sure that the handle starts with an @ symbol
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterHandle = value;
                }

                else
                {
                    throw new Exception("The Twitter handle must begin with @");
                }
            }
        }

        public School()
        {

        }

        public School(string schoolName, int phoneNumber)
        {
            Name = schoolName;
            PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(Name);
            result.AppendLine(this.Address);
            result.AppendLine(this.ZipCode.ToString());
            result.AppendLine(this.City);
            result.AppendLine(this.Country);
            result.AppendLine(this.PhoneNumber.ToString());
            result.AppendLine(this.Website);
            return result.ToString();
        }
    }
}
