using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp.Models
{
    public class SearchResults
    {   
        [Key]
        public string BookName { get; set; }
        public string ChapterName { get; set; }
        public string VerseName { get; set; }
        public string VerseText { get; set; }
        public string Commenttext { get; set; }
    }
}
