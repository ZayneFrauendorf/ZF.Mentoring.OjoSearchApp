using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp.Models
{
    public class Chapter
    {
        public int ChapterID { get; set; }
        public string ChapterName { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
