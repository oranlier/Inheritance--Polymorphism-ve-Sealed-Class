using System;

namespace Inheritance__Polymorphism_ve_Sealed_Class
{
    //calılar sınıfının kalıtım verememesi için "sealed" anahtar sözcüğü kullanılır
    // bunun için aşağıdaki satır "public sealed class canlilar" şeklinde yazılabilirdi 
    public class canlilar
    {
        protected void Beslenme(){
            Console.WriteLine("Canlılar beslenir.");
        }

        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar.");
        }

        protected void Bosaltim(){
            Console.WriteLine("Canlılar bosaltım yapar.");
        }

        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }
    }
}