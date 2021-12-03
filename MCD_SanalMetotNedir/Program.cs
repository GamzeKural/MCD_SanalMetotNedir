using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_SanalMetotNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sanal Metot Nedir?
             * Sanal Metot dediğimiz baseclass içerisinde bulunan bir metodun istenirse
             * türeyen sınıf içerisinde nasıl yeniden şekillenebileceğini inceleyeceğiz.
             * 
             * Kalıtım konusunda tüm nesnelerin object nesnesinden kalıtıldığını ve bazı
             * metotların object nesnesinden bize geldiğini söylemiştik.
             * 
             * Sanal metot anlatımına object içerisinde bize standart olarak gelen toString
             * metotunu inceleyerek başlaayacağız.
             * 
             * Sanal metotları, X-men filminde bulunan mystique karakterine benzeebiliriz.
             * Ortama göre kendi şeklini değiştirebilen bir karakter olması buna bir örnek olabilir.
             * 
             * Object => ToString();
             * Musteri M1 = new Musteri();
             * Object => Musteri
             *           M1.ToString();
             *           
             * Namespace.Musteri
             */

            Musteri M1 = new Musteri();
            M1.isim = "Gamze";
            M1.soyisim = "Kural";
            Console.WriteLine(M1.ToString());

            //Console.WriteLine(M1.ToString()+" - "+M1.GetHashCode()+" - "+M1.Equals(M1));


            Console.ReadKey();
        }
    }
}
