using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZF.Mentoring.OjoSearchApp.Models
{
    public class UpdateSearchResults
    {
        public string Query { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }

        public int Total { get; set; }
        public List<VerseUpdate> Verses { get; set; }


    }
}
