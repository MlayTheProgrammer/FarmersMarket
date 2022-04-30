using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Farmers_MarketTemp
{
    class Farmer : IFarmer
    {
        static Dictionary<string, string> mydictionary = new Dictionary<string, string>();
        public string Name { get; set; }
        public string Food { get; set; }
        
        public Farmer(string name)
        {
            Name = name;
            //Food = food;
        }
        public string fruitsAndVeggies(string food) 
        {
            Food = food;
            return Food;
        }
        static string userName;
        static string foodName;
        static void Main(string[] args)
        {
            Console.WriteLine("How many stand do you want? ");
            int stands = int.Parse(Console.ReadLine());
            List<string> users = new List<string>();
            List<string> listfood = new List<string>();
            for (int i = 1; i <= stands; i++)
            {
                 
                //Console.WriteLine($"Stand {i}:");
                stand(i, users, listfood);
            }
         
        }
        static int stand(int num, List<string> listFood, List<string>listName)
        {
            Console.WriteLine("this is stand #: :" + num);
            bool exit = false;
            Console.WriteLine("Please specify a name.");
            userName = Console.ReadLine();
            listName.Add(userName);
            Console.WriteLine("Please specify a food.");
            foodName = Console.ReadLine();
            Farmer user = new Farmer(userName);    
            listFood.Add(foodName);
            
            mydictionary.Add(userName, foodName);
            user.fruitsAndVeggies(foodName);
            while (!exit)
            {
                Console.WriteLine("So what do you want to do? ");
                string read = Console.ReadLine();
                if (read == "check")
                {

                    Console.WriteLine("\nWhat user? :");
                    string temp = Console.ReadLine();
                    check(temp);

                }

                else if (read == "buy")
                {
                    Console.WriteLine("Who do you want to buy from? ");
                    string read2 = Console.ReadLine();
                    buy(read2);
                }
                    Console.WriteLine("Is that it? ");
                    string next2 = Console.ReadLine();
                    exit = (next2 == "Y");
                }
            return num;
        }
            
        //what I am trying to fix
        static void check(string temp) 
        {

            Farmer user = new Farmer(temp);
            if (user.Name == temp)
            {
               
                Console.WriteLine(mydictionary[user.Name]);
                
            }
            else if (user.Name != temp) 
            {
                Console.WriteLine("This user is not here ");
            }
          
        }
        //Ignore this, will fix this later
        static void buy(string name)
        {

            //   Console.WriteLine("What farmer do you want to buy from? ");
            // String from = Console.ReadLine();
            Farmer user = new Farmer(name);
            Console.WriteLine($"\nWhat do you want to buy?  :");
            String temp = Console.ReadLine();
            
            if (mydictionary.ContainsKey(name))
            {
                //listfood.Remove(user.fruitsAndVeggies(temp));
                mydictionary.Remove(name);
            }
            mydictionary.Add(name, "");
            Console.ReadKey();

        }
        //Ignore this, will fix this later
        static void searchProduct()
        {
            Console.WriteLine("What do you want to look for? ");
            string search = Console.ReadLine();
           // Farmer user = new Farmer(userName);
           /* bool isExist = listfood.Contains(search);
            if (isExist) 
            {
                Console.WriteLine();
            }*/
        }
    }
}

