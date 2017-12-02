using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoyOI.IcM.Models
{
    public enum OnCallRole
    {
        Primary,
        Backup
    }

    public class OnCallSchedule
    {
        public Guid Id { get; set; }

        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public OnCallRole Role { get; set; }

        public DateTime From { get; set; }

        public DateTime To { get; set; }
    }
}
