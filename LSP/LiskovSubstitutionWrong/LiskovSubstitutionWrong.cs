using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.LiskovSubstitutionWrong
{
    public class LiskovSubstitutionWrong
    {
        static void Main(string[] args)
        {
            //Liskov substitution principle wrong
            Kus kanatli = new Guvercin();
            kanatli.Uc();
            kanatli.Yuru();
            kanatli = new Tavuk();
            kanatli.Uc(); //Bu metod çağırıldığında throw new NotImplementedException() 
                          //hatası fırlatacaktır. Çünkü kullanılmakta fakat metodun içi boş olduğu için bu durum oluşmuştur.
            kanatli.Yuru();
            Console.WriteLine("Hello World!");
        }
        public abstract class Kus
        {
            public abstract string Uc();
            public abstract string Yuru();
        }
        public class Tavuk : Kus
        {
            public override string Uc()
            {
                throw new NotImplementedException();
            }
            public override string Yuru()
            {
                return "Yürüdü..";
            }
        }
        public class Guvercin : Kus
        {
            public override string Uc()
            {
                return "Uçtu..";
            }
            public override string Yuru()
            {
                return "Yürüdü..";
            }
        }

    }
}
