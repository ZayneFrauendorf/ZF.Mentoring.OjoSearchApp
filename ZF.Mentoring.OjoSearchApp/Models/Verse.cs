using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp.Models
{
    public class Verse
    {
        public int VerseID { get; set; }
        public string VerseName { get; set; }
        public int ChapterID { get; set; }
        public Chapter Chapter { get; set; }
        public string Text { get; set; }

    }
}
