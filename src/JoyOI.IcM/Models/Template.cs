using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoyOI.IcM.Models
{
    public class Template
    {
        public long Id { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        [MaxLength(4000)]
        public string Body { get; set; }

        [MaxLength(4000)]
        public string Description { get; set; }

        [MaxLength(256)]
        public string TsgUrl { get; set; }
    }
}
