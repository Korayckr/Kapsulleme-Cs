using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKapsulleme
{
    class Ogrenci
    {

        // Kapsüllemede ana amaç normalde private olan bir değişkeni istenilen noktalarda kullanabilmek
        // Bunun içinse GET ve SET isimli methodlarda tanımlanan değişkene private olan değişken eşlenir ve gönderilir.
        private string isim;



        public void setIsim(string _isim)
        {
            isim = _isim;  

        }

        public string getIsim()
        {
            return isim;
        }


    }
}
