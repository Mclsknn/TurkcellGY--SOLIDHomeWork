using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.DependencyInjectionCorrect
{
    public class DependencyInjectionCorrect
    {
        //Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
        static void Main(string[] args)
        {
            IUretimOtomobil uretimOtomobil = new OtomobilUretim();
            OtomobilManager otomobilManager = new OtomobilManager(uretimOtomobil);

            IUretimTraktor uretimTraktor = new TraktorUretim();
            TraktorManager traktorManager = new TraktorManager(uretimTraktor);

            IUretimMotorsiklet uretimMotorsiklet = new MotorsikletUretim();
            MotorsikletManager motorsikletManager = new MotorsikletManager(uretimMotorsiklet);

            Motorsiklet mlet = new Motorsiklet();
            mlet.Id = 1;
            mlet.ProductName = "Honda";
            mlet.ProductModel = "PX450";
            mlet.ProductColor = "Kırmızı";

            Otomobil oto = new Otomobil();
            oto.Id = 2;
            oto.ProductName = "Mercedes";
            oto.ProductModel = "C180D";
            oto.ProductColor = "Beyaz";

            Traktor traktor = new Traktor();
            traktor.Id = 2;
            traktor.ProductName = "Isuzu";
            traktor.ProductModel = "C180D";
            traktor.ProductColor = "Beyaz";

            uretimOtomobil.ParcalariMonteEt(oto);
            uretimMotorsiklet.ParcalariMonteEt(mlet);
            uretimTraktor.ParcalariMonteEt(traktor);

        }
        public class OtomobilManager
        {
            private IUretimOtomobil _iUretim;

            public OtomobilManager(IUretimOtomobil iUretim)
            {
                _iUretim = iUretim;
            }

            public void Uret(Otomobil arac)
            {
                _iUretim.ParcalariMonteEt(arac);
            }

        }
        public class TraktorManager
        {
            private IUretimTraktor _iUretim;

            public TraktorManager(IUretimTraktor iUretim)
            {
                _iUretim = iUretim;
            }

            public void Uret(Traktor arac)
            {
                _iUretim.ParcalariMonteEt(arac);
            }

        }
        public class MotorsikletManager
        {
            private IUretimMotorsiklet _iUretim;

            public MotorsikletManager(IUretimMotorsiklet iUretim)
            {
                _iUretim = iUretim;
            }

            public void Uret(Motorsiklet arac)
            {
                _iUretim.ParcalariMonteEt(arac);
            }

        }

        public interface IUretimTraktor
        {

            public bool ParcalariMonteEt(Traktor arac);

        }
        public interface IUretimMotorsiklet
        {

            public bool ParcalariMonteEt(Motorsiklet arac);

        }
        public interface IUretimOtomobil
        {

            public bool ParcalariMonteEt(Otomobil arac);

        }

        public class MotorsikletUretim : IUretimMotorsiklet
        {
            public bool ParcalariMonteEt(Motorsiklet arac)
            {
                Console.WriteLine("Motosiklet üretildi");
                return true;
            }
        }
        public class OtomobilUretim : IUretimOtomobil
        {
            public bool ParcalariMonteEt(Otomobil arac)
            {
                Console.WriteLine("Otomobil üretildi");
                return true;
            }
        }
        public class TraktorUretim : IUretimTraktor
        {
            public bool ParcalariMonteEt(Traktor arac)
            {
                Console.WriteLine("Traktor üretildi");
                return true;
            }
        }


        public interface IArac { }

        public class Motorsiklet : Arac, IArac
        {

        }

        public class Traktor : Arac, IArac
        {

        }
        public class Otomobil : Arac, IArac
        {

        }
        public class Arac
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string ProductModel { get; set; }
            public string ProductColor { get; set; }
        }
    }
}
