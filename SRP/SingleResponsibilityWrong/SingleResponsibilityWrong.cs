using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.SingleResponsibilityWrong
{
    public class SingleResponsibilityWrong
    {
        //Single responsibility principle wrong
        //Bir class veya methodun yanlızca bir görevi olmalıdır

        public class Employee
        {
            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }


            // Rapor oluşturmak için kullanılan metod
            public void RaporOlustur(Employee em)
            {
                // Rapor oluşturma.
            }
        }
    }
}
