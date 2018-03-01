using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{

    class ReportAssignment : IScore
    {
        public string Title { get; set; }
        public int Chars { get; set; }
        public Student Author { get; set; }
        public float Score { get; set; }
        //GET THE HIGHEST SCORE NOT THE MAXIMUM POSSIBLE SCORE!
        public float MaximumScore { get; set; }

    }
}
