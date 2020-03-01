using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp.Models
{
    public class VerseUpdate
    {
        public string Id { get; set; }
        public string OrgId { get; set; }

        public string BookId { get; set; }

        public string BibleId { get; set; }

        public string ChapterId { get; set; }

        public string Reference { get; set; }
        public string Text { get; set; }
        public string BookName { get; set; }
        public string ChapterName { get; set; }
        public string VerseName { get; set; }


    }
}
