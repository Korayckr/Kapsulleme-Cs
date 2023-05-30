using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsulleme
{
    class Program
    {

        static void Main(String[] args)
        {

            // Bu kısımda da ilk oluşturulan öğrenci classından türerilen nesneyle get set üzerinden private değişkeni kullanıldı.
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.setIsim("Koray");

            string gelen = ogrenci1.getIsim();

            if (gelen == "Koray Çakır")
            {
                Console.WriteLine("Öğrenci'nin Adı: Koray, Soyadi: Çakır");
            }
            else
            {
                Console.WriteLine("Öğrenci'nin Adı: Koray, Soyadi: Çakır degildir");
            }
            Console.ReadKey();
        }

    }
}
