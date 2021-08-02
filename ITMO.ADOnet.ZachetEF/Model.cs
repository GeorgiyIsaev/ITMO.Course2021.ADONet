using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADOnet.ZachetEF
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Group { get; set; }
       
       
        public override string ToString()
        {
            string s = Name + " " + Surname + " (группа: " + Group + ")";
            return s;
        }

    }

}
