using System;

namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Animal animal = new Animal();
      Vertebrate vert = new Vertebrate();
      Invertebrate invert = new Invertebrate();
      WarmBlooded warm = new WarmBlooded();
      ColdBlooded cold = new ColdBlooded();
      JointedLegs joint = new JointedLegs();
      WithoutLegs without = new WithoutLegs();
      Mammals bear = new Mammals();
      Bird eagle = new Bird();
      Fish guppy = new Fish();
      Reptile snake = new Reptile();
      Amphibian frog = new Amphibian();
      Platypus platypus = new Platypus();
        // Console.WriteLine(platypus.layEggBeakVenom());

      Penguin pinguin = new Penguin();



      Amphibian theFrogPrince = new Amphibian();
        Console.WriteLine(theFrogPrince.croak());
        Console.WriteLine(theFrogPrince.talk());

      Bird parrot = new Bird();
        Console.WriteLine(parrot.talk());

      Console.WriteLine("Hello World!");
    }
  }

  class Animal
  {
    public void eat()
    {
      Console.WriteLine("Nom, nom, nom...");
    }

    public void breath()
    {
      Console.WriteLine("Breath in, breath out.");
    }
  }


    class Vertebrate : Animal
    {
      public bool backbone = true;
    }
    

    class Invertebrate : Animal
    {
      public bool backbone = false;
    }


    class WarmBlooded : Vertebrate
    {
      public bool warm = true;
    }
    

    class ColdBlooded : Vertebrate
    {
      public bool cold = true;
    }


    class JointedLegs : Invertebrate
    {
      public bool jointed = true;
      public bool without = false; 
    }


    class WithoutLegs : Invertebrate
    {
      public bool jointed = false;
      public bool without = true;
    }


    class Mammals : WarmBlooded
    {
      public bool furOrHair = true;
      public bool milk = true;
      public bool layEggs = false;
      public bool venomous = false;
      public bool beak = false;
      public bool fly = false;
      
      public virtual void layEggBeakVenom()
      {
        Console.WriteLine("I'm not venomous, don't have beaks, and don't lay eggs");
      }
    }


    class Platypus : Mammals
    {
      public override void layEggBeakVenom()
      {
        
        Console.WriteLine("I have a beak, laying eggs and I'm venomous");
      }
    }


    class Bird : Vertebrate 
    {
      public bool furOrHair = false;
      public bool milk = false;
      public bool layEggs = true;

      public virtual void fly()
      {
        Console.WriteLine("Flap, flap, flap...");
      }

      public string talk()
      {
        return "Privet";
      }
    }


    class Penguin : Bird
    {
      public override void fly() 
      {
        Console.WriteLine("I cannot fly!");
      }
    }


    class Fish : ColdBlooded
    {
      public bool gillsScalesFins = true;
      public bool scalySkin = false;
    }


    class Reptile : ColdBlooded
    {
      public bool scalySkin = true;
      public bool gillsScalesFins = false;
      public bool bornOnLand = true;
      public bool bornInWater = false;

      public void crawl()
      {
        Console.WriteLine("Crawl, crawl, crawl...");
      }
    }


    class Amphibian : ColdBlooded
    {
      public bool bornInWater = true;
      public bool bornOnLand = false;

      public bool gillsThenLungs = true;

      public void leap()
      {
        Console.WriteLine("Leap, leap, leap...");
      }

      public string croak()
      {
        return "Croak, croak, croak...";
      }

      public string talk()
      {
        return "Princess would you like me to help you get the ball out of the lake?";
      }
    }


    class Pairs : WithoutLegs
    {

    }

    class MoreThan3 : JointedLegs
    {

    }

    class WormLike : WithoutLegs
    {

    }

    class NotWorm : WithoutLegs
    {

    }
  }



