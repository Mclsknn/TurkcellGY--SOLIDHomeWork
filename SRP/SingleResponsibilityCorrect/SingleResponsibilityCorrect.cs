using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.SingleResponsibilityCorrect
{
    public class SingleResponsibilityCorrect
    {
        //Single responsibility principle correct
        //Bir class veya methodun yanlızca bir görevi olmalıdır
        //Rapor oluşturma sınıfında yapılan değişiklik Employee sınıfını etkilememelidir.

        public class Employee
        {

            public int EmployeeId { get; set; }
            public string EmployeeName { get; set; }
        }
        public class RaporOlusturma
        {
            /// Rapor oluşturmak için kullanılan metod
            public void RaporOlustur(Employee em)
            {
                // Employee verilerine ait rapor oluşturma.
            }
        }
    }
}
