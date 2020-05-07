using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloToLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            // 這個 new 有加入物件型態
	    // 所以會失去聚合效果
	    var lookup = getDatas().ToLookup(a => new CheckResult
            {
                PatientId = a.PatientId,
                CheckId = a.CheckId,
                Maximun = a.Maximun,
                Minimun = a.Minimun
            });
            //var lookup = getDatas().ToLookup(a => new
            //{
            //    a.PatientId,
            //    a.CheckId,
            //    a.Maximun,
            //    a.Minimun
            //});
            var groupCount = 0;
            var itemCount = 0;
            foreach (var group in lookup)
            {
                groupCount++;
                foreach (var item in group)
                {
                    itemCount++;
                }
            }

            Console.WriteLine(groupCount);
            Console.WriteLine(itemCount);
            Console.ReadKey();
        }

        static List<CheckAllData> getDatas()
        {
            return new List<CheckAllData>()
            {
                new CheckAllData { PatientId = "12345", CheckId = "1", Maximun = 4.5, Minimun = 3,RecDate = new DateTime(2020, 1, 1), TestNum = 5.3},
                new CheckAllData { PatientId = "12345", CheckId = "1", Maximun = 4.5, Minimun = 3,RecDate = new DateTime(2020, 2, 1), TestNum = 3.3},
                new CheckAllData { PatientId = "12345", CheckId = "1", Maximun = 4.5, Minimun = 3,RecDate = new DateTime(2020, 3, 1), TestNum = 4.3},
                new CheckAllData { PatientId = "12345", CheckId = "1", Maximun = 4.5, Minimun = 3,RecDate = new DateTime(2020, 4, 1), TestNum = 3.9},
                new CheckAllData { PatientId = "12345", CheckId = "1", Maximun = 4.5, Minimun = 3,RecDate = new DateTime(2020, 5, 1), TestNum = 7.0},
                new CheckAllData { PatientId = "12345", CheckId = "2", Maximun = 8.5, Minimun = 11,RecDate = new DateTime(2020, 1, 1), TestNum = 11},
                new CheckAllData { PatientId = "12345", CheckId = "2", Maximun = 8.5, Minimun = 11,RecDate = new DateTime(2020, 2, 1), TestNum = 12},
                new CheckAllData { PatientId = "12345", CheckId = "2", Maximun = 8.5, Minimun = 11,RecDate = new DateTime(2020, 3, 1), TestNum = 15},
                new CheckAllData { PatientId = "12345", CheckId = "2", Maximun = 8.5, Minimun = 11,RecDate = new DateTime(2020, 4, 1), TestNum = 13},
                new CheckAllData { PatientId = "12345", CheckId = "2", Maximun = 8.5, Minimun = 11,RecDate = new DateTime(2020, 5, 1), TestNum = 8},
            };
        }
    }
}
