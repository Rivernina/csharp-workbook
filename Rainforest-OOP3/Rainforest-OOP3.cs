using System;
using System.Collections.Generic;

namespace RainForest 
{
    public class Program 
    {
        public static void Main (string[] args) 
        {
          Company rainforest = new Company ("Rainforest, LLC");
          Console.WriteLine("----------------------");
          Console.WriteLine(rainforest.name);
          Console.WriteLine("----------------------");

          WarehousingGroup austin = new WarehousingGroup("Austin Warehousing Group", 2);
          WarehousingGroup houston = new WarehousingGroup("Houston Warehousing Group", 3);
          WarehousingGroup dallas = new WarehousingGroup("Dallas Warehousing Group", 1);
          WarehousingGroup sanantonio = new WarehousingGroup("San Antonio Warehousing Group", 3);

          rainforest.warehousingGroups.Add(austin);
          rainforest.warehousingGroups.Add(houston);
          rainforest.warehousingGroups.Add(dallas);
          rainforest.warehousingGroups.Add(sanantonio);

          Warehouse northAustin = new Warehouse("\tNorth Austin", 2);
          Warehouse southAustin = new Warehouse("\tSouth Austin", 2);
          Warehouse northHouston = new Warehouse("\tNorth Houston", 2);
          Warehouse southHouston = new Warehouse("\tSouth Houston", 2);
          Warehouse centralHouston = new Warehouse("\tCentral Houston", 2);
          Warehouse centralDallas = new Warehouse("\tCentral Dallas", 2);
          Warehouse northSanantonio = new Warehouse("\tNorth San Antonio", 2);
          Warehouse southSanantonio = new Warehouse("\tSouth San Antonio", 2);
          Warehouse centralSanantonio = new Warehouse("\tCentral San Antonio", 2);

          austin.warehouses.Add(northAustin);
          austin.warehouses.Add(southAustin);
          houston.warehouses.Add(northHouston);
          houston.warehouses.Add(southHouston);
          houston.warehouses.Add(centralHouston);
          dallas.warehouses.Add(centralDallas);
          sanantonio.warehouses.Add(northSanantonio);
          sanantonio.warehouses.Add(southSanantonio);
          sanantonio.warehouses.Add(centralSanantonio);
            
            // string[] houstonWarehouses = new string[] { "North Houston", "South Houston", "Central Houston" };
            // foreach (var houstonWarehouse in houstonWarehouses)
            // {
            //     Warehouse warehouse = new Warehouse(houstonWarehouse, 2);
            //     houston.warehouses.Add(warehouse);
            // }

          Container nAu = new Container("\t\tContainer-01", 2);
          northAustin.containers.Add(nAu);
          Container sAu = new Container("\t\tContainer-02", 2);
          southAustin.containers.Add(sAu);
          Container nHou = new Container("\t\tContainer-01", 3);
          northHouston.containers.Add(nHou);
          Container sHou = new Container("\t\tContainer-02", 3);
          southHouston.containers.Add(sHou);
          Container cenHou = new Container("\t\tContainer-03", 3);
          centralHouston.containers.Add(cenHou);
          Container cenDal = new Container("\t\tContainer-01", 1);
          centralDallas.containers.Add(cenDal);
          Container nSA = new Container("\t\tContainer-01", 3);
          northSanantonio.containers.Add(nSA);
          Container sSA = new Container("\t\tContainer-02", 3);
          southSanantonio.containers.Add(sSA);
          Container cenSA = new Container("\t\tContainer-03", 3);
          centralSanantonio.containers.Add(cenSA);


          Item milk = new Item("\t\t\tDairy:\n" + "\t\t\tmilk", 3.99);
          nAu.items.Add(milk);
          nHou.items.Add(milk);
          nSA.items.Add(milk);

          Item paper = new Item("\t\t\tPaper Goods:\n" + "\t\t\tpaper towels", 3.99);
          nAu.items.Add(paper);
          nHou.items.Add(paper);
          nSA.items.Add(paper);

          Item coffee = new Item("\t\t\tBeverages:\n" + "\t\t\tcoffee", 8.99);
          sAu.items.Add(coffee);
          sHou.items.Add(coffee);
          sSA.items.Add(coffee);

          Item tea = new Item("\t\t\ttea", 4.99);
          sAu.items.Add(tea);
          sHou.items.Add(tea);
          sSA.items.Add(tea);

          Item vegetables = new Item("\t\t\tCanned Goods:\n" + "\t\t\tvegetables", 0.99);
          cenHou.items.Add(vegetables);
          cenSA.items.Add(vegetables);
          cenDal.items.Add(vegetables);

          Item sauce = new Item("\t\t\tspagetti sauce", 0.69);
          cenHou.items.Add(sauce);
          cenSA.items.Add(sauce);
          cenDal.items.Add(sauce);


        
          rainforest.GenerateManifest();


          // Dictionary<string, string[]> categories = new Dictionary<string, string[]>();
        
          // categories.Add("Beverages", new string[] { "coffee", "tea", "juice", "soda" });
          // categories.Add("Canned Goods", new string[] { "vegetables", "spaghetti sauce", "ketchup" });
          // categories.Add("Paper Goods", new string[] { "paper towels", "toilet paper", "aluminum foil", "sandwich bags" });
          // categories.Add("Personal Care", new string [] { "shampoo", "soap", "hand soap", "shaving cream" });
        
          // foreach (var key in categories.Keys)
          // {
          //    Console.WriteLine("\nGroceries List: " + key);
          //    foreach (var category in categories[key])
          //    {
          //       Console.WriteLine(category);
          //    }
          // Console.WriteLine("Count: {0}", categories.Count); 


            //string[] cities = new string[] { "Austin", "Houston", "Dallas", "San Antonio" };
            //string[] items = new string[] { "Banana", "Toothpaste", "Baseball", "Laptop" };
      }
    }

    


    class Company 
    {
      public string name;
      public List<WarehousingGroup> warehousingGroups;


      public Company (string name) 
      {
        this.name = name;
        this.warehousingGroups = new List<WarehousingGroup> ();
      }
        
      public string Name
      {
        get;
        private set;
      }

       public string WarehousingGroup
      {
        get;
        private set;
      } 

      public void AddWarehousingGroup (WarehousingGroup warehousingGroup, int location)
      {
        warehousingGroups[location] = warehousingGroup;
      }


      public void GenerateManifest()
      {
        foreach(WarehousingGroup warehousingGroups in this.warehousingGroups)
        {
          Console.WriteLine(String.Format("\n{0}:", warehousingGroups.location));
          foreach(Warehouse warehouses in warehousingGroups.warehouses)
          {
            Console.WriteLine(String.Format("{0}:", warehouses.location));
            foreach(Container containers in warehouses.containers)
            {
              Console.WriteLine(String.Format("{0:}", containers.id));   
              foreach(Item item in containers.items)
              {
                Console.WriteLine(String.Format("{0}, {1}", item.name, item.price));
              }
            }
          }
        }
      }
    }
    
    


    class WarehousingGroup
    {
      public string location;
      public int size;

      public List<Warehouse> warehouses;

      public WarehousingGroup (string location, int size)
      {
        this.location = location;
        this.size = size;
        this.warehouses = new List<Warehouse>();
      }

      public string Location 
      {
        get;
        private set;
      }

      public string Size 
      {
        get;
        private set;
      }

      public List<Warehouse> Warehouses 
      {
        get;
        private set;
      }

      public void AddWarehouse (Warehouse warehouse, int location)
      {
        warehouses[location] = warehouse;
      }
    }



    class Warehouse
    {
      public string location;
      public int size;
      public List<Container> containers;
    
            
      public Warehouse (string location, int size)
      {
        this.location = location;
        this.size = size;
        this.containers = new List<Container>();
      }

      public string Location 
      {
        get;
        private set;
      }

      public string Size 
      {
        get;
        private set;
      }

      public List<Container> Containers 
      {
        get;
        private set;
      }
                
    }



    class Container 
    {
      public string id;
      public int size;
      public List<Item> items;
    

      public Container (string id, int size) 
      {
        this.id = id;
        this.size = size;
        this.items = new List<Item> ();
      }

      public string Id
      {
        get;
        private set;
      }

      public int Size
      {
        get;
        private set;
      }
    }



    class Item 
    {
      public string name;
      public double price;

      public Item (string name, double price) 
      {
        this.name = name;
        this.price = price;
      }

      public string Name
      {
        get;
        private set;
      }

      public double Price
      {
        get;
        private set;
      }
    }
}

