using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }
        // User
        public DateTime CommentDate { get; set; }
        public int VerseID { get; set; }
        public Verse Verse { get; set; }
    }
}
