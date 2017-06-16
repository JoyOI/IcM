using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoyOI.IcM.VmMonitor
{
    public class DiskInfo
    {
        public DiskInfo()
        { }

        public DiskInfo(string name, long size, long free)
        {
            this.Name = name;
            this.Size = size;
            this.Free = free;
        }

        public string Name { get; set; }

        public long Size { get; set; }

        public long Free { get; set; }
    }
}
