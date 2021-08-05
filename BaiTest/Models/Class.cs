using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTest.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}