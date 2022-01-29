using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;

namespace BreakTime
{
    class ResourcesMonitor
    {
        PerformanceCounter cpuUsage;
        PerformanceCounter memUsage;
        PerformanceCounter pageUsage;

        public ResourcesMonitor()
        {
            cpuUsage = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            memUsage = new PerformanceCounter("Memory", "Available MBytes");
            pageUsage = new PerformanceCounter("Paging File", "% Usage", "_Total");
        }

        public string[] GetCPUUsage()
        {
            string[] result = new string[2];
            result[0] = "Processor " + cpuUsage.NextValue() + " %";
            result[1] = "memory free  " + memUsage.NextValue() + " mb";
            //добавить System.Management
            //string Query = "SELECT MaxCapacity FROM Win32_PhysicalMemoryArray";
            //ManagementObjectSearcher searcher = new ManagementObjectSearcher(Query);
            //foreach (ManagementObject WniPART in searcher.Get())
            //{
            //    UInt32 SizeinKB = Convert.ToUInt32(WniPART.Properties["MaxCapacity"].Value);
            //    UInt32 SizeinMB = SizeinKB / 1024;
            //    UInt32 SizeinGB = SizeinMB / 1024;
            //    cont.Children.Add(new Label() { Content = "memory " + ((memUsage.NextValue() / SizeinMB) * 100) + "% used" });
            //    cont.Children.Add(new Label() { Content = "memory used " + (SizeinMB - memUsage.NextValue()) });
            //    cont.Children.Add(new Label() { Content = "page used " + pageUsage.NextValue() });
            //}

            return result;
        }
    }
}
