using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp
{
    public class SearchResultViewModel
    {
        public int VerseID { get; set; }
        public string VerseName { get; set; }
        public string VerseText { get; set; }
        public int ChapterID { get; set; }
        public string ChapterName { get; set; }
        public int BookID { get; set; }
        public string BookName { get; set; }
    }
}
