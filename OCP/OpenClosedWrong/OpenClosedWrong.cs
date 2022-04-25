using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OpenClosedWrong
{
    public class OpenClosedWrong
    {

        //Open closed principle wrong

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
        public class RaporOlusturma
        {
            /// Rapor oluşturmak için kullanılan metod
            public void RaporOlustur(Employee em, Rapor rp)
            {
                if (rp.RaporTipi == "CRS")
                {
                    // Crystal Report ile rapor oluştur
                }
                if (rp.RaporTipi == "PDF")
                {
                    // PDF formatında rapor oluştur
                }
            }
        }
    }
}
