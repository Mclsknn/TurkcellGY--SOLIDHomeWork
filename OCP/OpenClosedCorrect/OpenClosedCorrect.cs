using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OpenClosedCorrect
{
    public class OpenClosedCorrect
    {
        //Open closed principle correct
        //Open Closed prensibi, yazılım geliştirirken kullandığımız varlıkların (class, method vs.) gelişime açık,
        //kodların ise değişime kapalı olması ilkesidir.

        public class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
        }

        public abstract class Rapor
        {
            public int RaporId { get; set; }
            public string RaporAdi { get; set; }
            public string RaporTipi { get; set; }
            public abstract void RaporOlustur(Employee em);
            // Override edilecek olan metodumuzdur. Bu metod farklı tipte raporlamalar için kullanılacaktır.
        }

        class CrystalReportOlustur : Rapor
        {
            public override void RaporOlustur(Employee em)
            {
                // Crystal Report ile rapor oluştur
            }
        }

        class PDFRaporOlustur : Rapor
        {
            public override void RaporOlustur(Employee em)
            {
                // PDF ile rapor oluştur
            }
        }
    }
}
