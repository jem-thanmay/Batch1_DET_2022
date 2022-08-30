<<<<<<< HEAD
﻿using Batch1_DET_2022;

class MyClass
{
    //Emp grade

    /*enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    public static string GetGrade(int mark) //IN parameter
    {
        if (mark >= (int)Grade.Distinction)
            return "Distinction";
        else if (mark >= (int)Grade.Pass)
            return "PASS";
        else
            return "FAIL";
    }*/
  
        public static void Main()
        {


        //Employee

        /* try
         {
             Emp m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                                // Console.WriteLine(m.Print());

             Emp m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
             // Console.WriteLine(m1.Print());  //base class ref can point to derived object

             Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));
             //Console.WriteLine(e1.Print());

             Console.WriteLine("enter empid b.w 1001 - 25000");
             int id = Convert.ToInt32(Console.ReadLine());
             if (id < 1001 || id > 25000)
                 throw new InvalidEmployeeIDException("Entered empid is not in the range...");

             Console.WriteLine("enter emp name");
             string name = Console.ReadLine();

             Console.WriteLine("enter doj");
             DateOnly doj = DateOnly.Parse(Console.ReadLine());

             Emp e2 = new(id, name, doj);


             List<Emp> list = new List<Emp>();
             list.Add(m);
             list.Add(m1);
             list.Add(e1);
             foreach (Emp x in list)
                 Console.WriteLine(x.Print());
         }
         catch (InvalidEmployeeIDException e)
         {
             Console.WriteLine(e.Message);
         }
         catch (Exception e)
         { }*/

        //age

        /*try
        {

            Console.WriteLine("enter age b.w 0-100");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 100)
                throw new InvalidAgeException("Entered age is invalid...");


        }
        catch (InvalidAgeException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        { }*/

        //animal

        /*List<Animal> animal = new List<Animal>();
        animal.Add(new Dog());
        animal.Add(new Cat());
        foreach(Animal anim in animal)
            Console.WriteLine(anim.Sound());*/
        try

        {

            Person t = new Person("Thanmay", "Jembige", "thanmay.j@sonata-software.com", new DateOnly(2000,05,29));

            int byear = t.BirthYear();

            if (byear < 2000 || byear > 2022)

            {

                throw new InvalidEmpIDException("ENTER VALID BIRTH YEAR");

            }

            string r = t.GetSunSign();

            string s = t.ChineseZodiac();

            string w = t.IsAdult();

            string b = t.BDayStatus();

            string u = t.DefaultUsername();

            string n = t.GetInfo();

            Console.WriteLine($"NAME = {n}");

            Console.WriteLine($"Sun Sign = {r}");

            Console.WriteLine($"Chinese Zodiac = {s}");

            Console.WriteLine($"Age Status = {w}");

            Console.WriteLine($"Birthday Status = {b}");

            Console.WriteLine($"Default Username = {u}");

        }

        catch (InvalidEmpIDException e)

        {

            Console.WriteLine(e.Message);

        }

        catch (Exception m)

        {

            Console.WriteLine(m.Message);

        }

    }
}
      

=======
﻿
//Console.WriteLine("Hello, World!");
//Console.WriteLine("I am 22815");
>>>>>>> parent of e2d951c (Modified)
