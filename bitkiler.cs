using System;

namespace Inheritance__Polymorphism_ve_Sealed_Class
{
    public class Bitkiler : canlilar
    {
        protected void Fotosentezyapmak(){
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }

    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentezyapmak();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler:Bitkiler{

        public TohumsuzBitkiler()
        {
            base.Fotosentezyapmak();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();
        } 
        public void SporlalaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}