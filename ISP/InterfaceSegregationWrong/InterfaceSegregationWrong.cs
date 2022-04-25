using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.InterfaceSegregationWrong
{
    public class InterfaceSegregationWrong
    {

        //Interface segregation principle wrong

        public interface IFutbolcu
        {
            void DefansYap();
            void PenaltiKurtar();
            void PasAt();
            void OrtaAc();
            void GolAt();
        }
    }
}
