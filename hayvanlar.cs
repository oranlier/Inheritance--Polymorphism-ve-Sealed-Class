using System;

namespace Inheritance__Polymorphism_ve_Sealed_Class
{
    public class Hayvanlar : canlilar
    {
        public void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();// base şu demek: UyaranlaraTepki nin orjinal halini buraya koy
            Console.WriteLine("Hayvalar temasa tepki verir.");

        }
    }

    public class Sürüngenler:Hayvanlar
    {
        public void SurunerekHareketEderler(){
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar
    {
        public void Ucmak(){
            Console.WriteLine("Kuşlar uçar.");
        }
    }
}