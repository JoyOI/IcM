using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyOI.IcM.VmMonitor
{
    public class ProcessInfo
    {
        public ProcessInfo()
        { }

        public ProcessInfo(int id, string name, double totalProcessorTime, long workingSet64, string path)
        {
            this.Id = id;
            this.Name = name;
            this.TotalProcessorTime = totalProcessorTime;
            this.WorkingSet64 = workingSet64;
            this.Path = path;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double TotalProcessorTime { get; set; }

        public long WorkingSet64 { get; set; }

        public string Path { get; set; }
    }
}
