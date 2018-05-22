using System;
                    
public class Program
{
    public static void Main()
    {
        Car blueCar = new Car("blue", 4);
        Car blackCar = new Car("black", 4);
        Car redCar = new Car("red convertible", 2);
        Car whiteCar = new Car("white truck", 3);
        Car silverCar = new Car("broken silver", 4);

        Person driverPerson = new Person("one driver");
        Person teenagerPerson = new Person("a bunch of teenagers");
        Person mechanicPerson = new Person("an auto mechanic");
        Person technicianPerson = new Person("a technician");
        Person estimatorPerson = new Person("a repair estimator"); 
        
        
        Garage smallGarage = new Garage(2);
        Garage repairGarage = new Garage(3);


        blueCar.SitPerson(driverPerson, 0);
        blackCar.SitPerson(teenagerPerson, 1);
        redCar.SitPerson(mechanicPerson, 0);
        whiteCar.SitPerson(technicianPerson, 1);
        silverCar.SitPerson(estimatorPerson, 2);
        
        smallGarage.ParkCar(blueCar, 0);
        smallGarage.ParkCar(blackCar, 1);
        repairGarage.ParkCar(redCar, 0);
        repairGarage.ParkCar(whiteCar, 1);
        repairGarage.ParkCar(silverCar, 2);

        
        
        Console.WriteLine("\nLet's see how many cars and people are in a two-car residential garage:\n");
        Console.WriteLine(smallGarage.Cars);
        Console.WriteLine("{0,55}", "------------------------------------------\n");
        Console.WriteLine("Now let's see how many cars and people are in an auto repair garage:\n");
        Console.WriteLine(repairGarage.Cars);
        Console.WriteLine("That's all for today!");
    }
}

class Car
{
    public Person[] persons;

    public Car(string initialColor, int initialSeat)
    {
        Color = initialColor;
        Seat = initialSeat;
        this.persons = new Person[initialSeat];
    }
    
    public string Color { get; private set; }

    public int Seat { get; private set; }

    public void SitPerson (Person person, int seat)
    {
        persons[seat] = person;
    }
}




class Person
{
    public Person(string initialType)
    {
        Type = initialType;
    }

    public string Type { get; private set; }
}




class Garage
{
    private Car[] cars;
    
    public Garage(int initialSize)
    {
        Size = initialSize;
        this.cars = new Car[initialSize];
    }
    
    public int Size { get; private set; }
    
    public void ParkCar (Car car, int spot)
    {
        cars[spot] = car;
    }
    
    public string Cars 
    {
        get 
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] != null) 
                {
                    Console.Write(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                

                    for (int j = 0; j < cars[i].persons.Length; j++)
                    {
                        if (cars[i].persons[j] != null)
                        {
                            Console.WriteLine(String.Format(" There is {0} in that {1} car.", cars[i].persons[j].Type, cars[i].Color));
                        }
                    }
                }
            }
            return "";
        }
    }
}

