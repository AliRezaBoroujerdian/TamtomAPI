using System;
using System.Collections.Generic;
using System.Text;

namespace Tamtom.API.Version
{
    public class VersionModel
    {
        public int VersionID { get; set; }
        public string ProductName { get; set; }
        public string Platform { get; set; }
        public string TargetOS { get; set; }
        public string PlatformVersion { get; set; }
        public string Description { get; set; }
        public bool? IsRequired { get; set; }
        public bool? Stable { get; set; }
        public string CompanyName { get; set; }
        public string Authors { get; set; }
        public string Language { get; set; }
        public string Technology { get; set; }
        public string Key { get; set; }
        public bool? IsActive { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
