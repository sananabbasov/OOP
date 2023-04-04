using Claasses;
using Claasses.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        //// object
        //Student student1 = new();
        //student1.Name = "Qonce";
        //student1.Age = 19;
        //student1.Surname = "Abbasova";

        //// object
        //Student student2 = new()
        //{
        //    Name = "Qismet",
        //    Surname = "Huseynov",
        //    Age = 55
        //};




        //List<Student> students = new();
        //students.Add(student1);
        //students.Add(student2);


        //foreach (var item in students)
        //{
        //    Console.WriteLine(item.Name);
        //    Console.WriteLine(item.Surname);
        //}


        Menu kabab1 = new()
        {
            Name = "Lule",
            Price = 10,
            Description = "Quzu eti",
            Portion = 1,
            PhotoUrl = "img/1.png",
            CreatedDate = DateTime.Now.AddDays(1)
        };

        Menu kabab2 = new()
        {
            Name = "Tike",
            Price = 4,
            Description = "Inek eti",
            Portion = 1,
            PhotoUrl = "img/2.png",
            CreatedDate = DateTime.Now
        };

        List<Menu> menus = new();

        menus.Add(kabab1);
        menus.Add(kabab2);

        Evvele:

        Console.WriteLine("1. Menu");
        Console.WriteLine("2. Add to menu");
        Console.WriteLine("3. Order");


        int userInput = Convert.ToInt32(Console.ReadLine());


       

        switch (userInput)
        {
            case 1:
                foreach (var item in menus)
                {
                    Console.WriteLine($"{item.Name} {item.GetTax()}");
                }
                break;
            case 2:
                Console.Write("Adi daxil edin: ");
                string name = Console.ReadLine();
                Console.Write("Qiymeti daxil edin: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Haqqinda: ");
                string desc = Console.ReadLine();
                Console.Write("Qiymeti daxil edin: ");
                int porsion = Convert.ToInt32(Console.ReadLine());

                Menu newMenu = new()
                {
                    Name = name,
                    Price = price,
                    Description = desc,
                    Portion = porsion,
                };
                menus.Add(newMenu);
                break;

            case 3:

                break;
            default:
                break;
        }

        goto Evvele;
    }
}