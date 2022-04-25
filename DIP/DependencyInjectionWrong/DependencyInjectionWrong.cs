using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInjectionWrong
{
    public class DependencyInjectionWrong
    {

        //Dependency Inversion Principle correct
        //Aşağıdaki örneğimizde, Uretim high-level class tır. Araba ise low-level class tır.
        //Dolayısıyla Uretim class’ı içerisindeki UretimYap() metodu içindeki işlemler Araba class’ındaki ParcalariMonteEt() metoduna bağlıdır.
        //Araba class’ındaki metodlarda yapılacak olan değişiklikler üst class’ı da etkilemektedir.
        //Yani, Araba class’ına herhangi bir metod eklediğimizde gerektiğinde yine Uretim class’ındaki UretimYap()
        //metodunda da metod eklememiz gerekecektir. Yine bir bağımlılık söz konusudur.
        //Dolayısıyla, bu durum Dependency Inversion Prensibi’ne aykırıdır.

        public class Uretim
        {
            public void UretimYap()
            {
                Araba araba = new Araba();
                araba.ParcalariMonteEt();
            }
        }

        public class Araba
        {
            public bool ParcalariMonteEt()
            {
                //Montaj işlemleri..
                return true;
            }
        }

    }
}
