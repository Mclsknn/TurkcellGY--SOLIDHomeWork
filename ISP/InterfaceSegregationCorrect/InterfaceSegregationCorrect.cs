using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.InterfaceSegregationCorrect
{
    public class InterfaceSegregationCorrect
    {
   
       //Interface segregation correct
       //Interface Segregation prensibine göre, “istemcilerin kullanmadıkları arayüzleri uygulamaya zorlanmaması gerektiğini” savunulmaktadır.
       //Herbir interface’in belirli bir amacı olmalıdır. Tüm metodları kapsayan tek bir interface kullanmak yerine,
       //herbiri ayrı metod gruplarına hizmet veren birkaç interface tercih edilmektedir.

        public interface IFutbolcu
        {
            //Mevkilerde ortak yapılan görevler yazılmıştır.
            void OrtaAc();
            void PasAt();
        }
        public interface IForvet
        {
            void GolAt();
        }
        public interface IKaleci
        {
            void PenaltıKurtar();
        }
        public interface IStoper
        {
            void DefansYap();
        }

    }
}
