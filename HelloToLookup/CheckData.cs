using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloToLookup
{
    public class CheckAllData
    {
        public string PatientId { get; set; }
        public string CheckId { get; set; }
        public double? Maximun { get; set; }
        public double? Minimun { get; set; }
        public DateTime RecDate { get; set; }
        public double? TestNum { get; set; }

    }

    public class TestData
    {
        public DateTime RecDate { get; set; }
        public double? TestNum { get; set; }
    }

    public class CheckResult
    {
        public string PatientId { get; set; }
        public string CheckId { get; set; }
        public double? Maximun { get; set; }
        public double? Minimun { get; set; }

        public IEnumerable<TestData> ChkData { get; set; }
    }

    
}
