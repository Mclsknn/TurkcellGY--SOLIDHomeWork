using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.LiskovSubstitutionCorrect
{
    public class LiskovSubstitutionCorrect
    {
     
        //Liskov substitution principle correct

        //Liskov’un yerine geçme prensibi alt sınıflardan oluşturulan nesnelerin üst sınıfların nesneleriyle yer değiştirdiklerinde
        //aynı davranışı göstermek zorunda olduklarını söyler. Yani; türetilen sınıflar, türeyen sınıfların tüm özelliklerini
        //kullanmak zorundadır. Eğer kullanmaz ise ortaya işlevsiz, dummy kodlar çıkacaktır.
        //Bu durumda üst sınıfta if else blokları kullanarak tip kontrolü yapmamız gerekebilir ve böylelikle
        //Açık Kapalı prensibine de ters düşmüş oluruz.

        public interface IUcanlar
        {
            string Uc();
        }
        public interface IYuruyenler
        {
            string Yuru();
        }
        public class Tavuk : IYuruyenler
        {
            public string Yuru()
            {
                return "Yürüdü..";
            }
        }
        public class Guvercin : IYuruyenler, IUcanlar
        {
            public string Uc()
            {
                return "Uçtu..";
            }
            public string Yuru()
            {
                return "Yürüdü..";
            }
        }
    }
}
