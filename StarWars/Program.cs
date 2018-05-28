using System;

namespace StarWars
{
    public class Program
    {
    public static void Main()
    {
        Person leia = new Person("Leia", "Organa", "Rebel");
        Person darth = new Person("Darth", "Vader", "Imperial");
        Person luke = new Person("Luke", "Skywalker", "Rebel");
        Person han = new Person("Han", "Solo", "Rebel");
        Person emporer = new Person("Emporer", "Palpatine", "Imperial");
        Person ewok = new Person("Ewok", "Kolobok", "Rebel");
        Person tatoon = new Person("Tatoon", "Boltun", "Imperial");
        Person molchun = new Person("Molchun", "Xavrum", "Imperial");
        Person jabba = new Person("Jabba", "Hutt", "Imperial");
        Person hubba = new Person("Hubba", "Bubba :)", "Imperial");
       

        Ship xShip = new Ship("X-Wing", "StarFighter", "Rebel", 1);
        Ship tieShip = new Ship("Tie Fighter", "ATT Battle Tank", "Rebel", 1);
        Ship khetannaShip = new Ship("The Khetanna", "Luxury sail barge", "Rebel", 1);
        Ship monShip = new Ship("Mon Calamari", "Star Cruiser", "Imperial", 2);
        Ship falconShip = new Ship("Millennium Falcon", "Vulture Droid", "Rebel", 3);
        Ship advancedShip = new Ship("TIE Advanced x1", "Super Star Destroyer", "Imperial", 1);
        Ship imperialShip = new Ship("Imperial Shuttle", "TIE fighter", "Imperial", 1);
        

        Station rebelStation = new Station("Rebel Space", "Good Guys", 4);
        Station deathStation = new Station("Death Star", "Bad Guys", 3);

        xShip.EnterShip(han, 0);
        tieShip.EnterShip(leia, 0);
        khetannaShip.EnterShip(ewok, 0);
        monShip.EnterShip(tatoon, 0);
        monShip.EnterShip(molchun, 1);
        falconShip.EnterShip(darth, 0);
        falconShip.EnterShip(luke, 1);
        falconShip.EnterShip(emporer, 2);
        advancedShip.EnterShip(jabba, 0);
        imperialShip.EnterShip(hubba, 0);

        rebelStation.DockShip(xShip, 0);
        rebelStation.DockShip(tieShip, 1);
        rebelStation.DockShip(khetannaShip, 2);
        rebelStation.DockShip(monShip, 3);
        deathStation.DockShip(falconShip, 0);
        deathStation.DockShip(advancedShip,1 );
        deathStation.DockShip(imperialShip, 2);

        Console.WriteLine("\n===================================================================");
        Console.WriteLine("I have never seen Star Wars, and have no idea what it is all about.");
        Console.WriteLine("==================================================================\n");

        Console.WriteLine("Ships docked at the {0} station:\n", rebelStation.Name);
        Console.WriteLine(rebelStation.Ships);
        //Console.WriteLine("{0,55", "----------------------------------\n");
        Console.WriteLine("Ships docked at the {0} station:\n", deathStation.Name);
        Console.WriteLine(deathStation.Ships);

        rebelStation.Roster();
        deathStation.Roster();
    }
}

class Person
{
    private string firstName;
    private string lastName;
    private string alliance;
    public Person(string firstName, string lastName, string alliance)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.alliance = alliance;
    }

    public string FullName
    {
        get
        {
            return this.firstName + " " + this.lastName;
        }

        set
        {
            string[] names = value.Split(' ');
            this.firstName = names[0];
            this.lastName = names[1];
        }
    }
}


class Ship
{
    private Person[] passengers;
    public Ship(string nameShip, string type, string alliance, int initialSeat)
    {
        this.NameShip = nameShip;
        this.Type = type;
        this.Alliance = alliance;
        Seat = initialSeat;
        this.passengers = new Person[initialSeat];
      
    }

    public string NameShip 
    {
      get;
      private set;
    }

    public string Type
    {
        get;
        private set;
    }

    public string Alliance
    {
        get;
        private set;
    }

    public int Seat 
    {
      get;
      private set;
    }


    public string Passengers
    {
        get
        {
            foreach (var person in passengers)
            {
                Console.WriteLine(String.Format("{0}", person.FullName));
            }

            return " ";
        }
    }

    public void EnterShip(Person person, int seat)
    {
        passengers[seat] = person;
    }

    public void ExitShip(int seat)
    {
        passengers[seat] = null;
    }
  }



  class Station
  {
    private Ship[] ships;
    public Station(string initialName, string initialAlliance, int initialSize)
    {
      Name = initialName;
      Alliance = initialAlliance; 
      Size = initialSize;
      this.ships = new Ship[initialSize];
    }

    public string Name 
    { 
      get; 
      private set; 
    } 

    public string Alliance
    {
      get;
      private set;

    }

    public int Size
    {
      get;
      private set;
    }

    public void DockShip (Ship ship, int port)
    {
      ships[port] = ship;
    }

    
    public string Ships
    {
      get
      {
        for (int i = 0; i < ships.Length; i++)
        {
          if (ships[i] != null)
          {
            Console.WriteLine(String.Format("The {0}, {1} ship arrived at the port {2}.", ships[i].NameShip, ships[i].Type, i));  
          } 
        }
        return "";
      }
    }

public void Roster()
        {
            foreach (Ship ship in ships)
            {	
                Console.WriteLine("---------------------------");
                Console.Write("Space Ship: ");
                Console.WriteLine("{0}.", ship.NameShip);
                Console.Write("Space Travelers: ");
                Console.WriteLine("{0} ", ship.Passengers);
                Console.Write("Alliance: ");
                Console.WriteLine("{0}.\n", ship.Alliance);
            }
        }
    } 
  }


