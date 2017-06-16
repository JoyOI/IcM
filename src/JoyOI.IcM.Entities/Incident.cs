using System;
using System.Collections.Generic;
using System.Text;

namespace JoyOI.IcM.Entities
{
    public class Incident
    {
        public Guid Id { get; set; }

        public int Severity { get; set; }

        public string Body { get; set; }

        public DateTime Time { get; set; }

        public Guid ServerId { get; set; }
    }
}
