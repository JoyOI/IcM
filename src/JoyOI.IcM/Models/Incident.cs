using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace JoyOI.IcM.Models
{
    public enum IncidentStatus
    {
        Active,
        Mitigated,
        Resolved
    }

    public enum CallStage
    {
        Primary,
        Backup,
        Manager,
        Author
    }

    public class Incident
    {
        public long Id { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        [MaxLength(4000)]
        public string Body { get; set; }

        [MaxLength(128)]
        public string Type { get; set; }

        [MaxLength(128)]
        public string Key { get; set; }

        [ForeignKey("Owner")]
        public Guid? OwnerId { get; set; }

        public virtual User Owner { get; set; }

        [ForeignKey("Acker")]
        public Guid? AckerId { get; set; }

        public virtual User Acker { get; set; }

        [ForeignKey("Parent")]
        public long? ParentId { get; set; }

        public virtual Incident Parent { get; set; }

        public IncidentStatus Status { get; set; }

        public int CallRound { get; set; }

        public CallStage CallStage { get; set; }

        public int Severity { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? MitigateTime { get; set; }

        public DateTime? ResolveTime { get; set; }

        [ForeignKey("Template")]
        public long? TemplateId { get; set; }

        public virtual Template Template { get; set; }

        public virtual ICollection<Incident> Children { get; set; } = new List<Incident>();
    }
}
