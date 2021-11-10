using LearnPrototype.Classes;
using System;

namespace LearnPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            

                Blog p1 = new Blog();
                p1.URL = "abc.com";
                p1.PublishDate = Convert.ToDateTime("1977-01-01");
                p1.Post = new Post("test1");

                // Perform a shallow copy of p1 and assign it to p2.
                Blog p2 = p1.ShallowCopy();
                // Make a deep copy of p1 and assign it to p3.
                Blog p3 = p1.DeepCopy();

                // Display values of p1, p2 and p3.
                Console.WriteLine("Original values of p1, p2, p3:");
                Console.WriteLine("   p1 instance values: ");
                DisplayValues(p1);
                Console.WriteLine("   p2 instance values:");
                DisplayValues(p2);
                Console.WriteLine("   p3 instance values:");
                DisplayValues(p3);

                // Change the value of p1 properties and display the values of p1,
                // p2 and p3.
                p1.URL = "bcd.com.vn";
                p1.PublishDate = Convert.ToDateTime("1900-02-02");
                p1.Post.Title = "test2";
                Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
                Console.WriteLine("   p1 instance values: ");
                DisplayValues(p1);
                Console.WriteLine("   p2 instance values (reference values have changed):");
                DisplayValues(p2);
                Console.WriteLine("   p3 instance values (everything was kept the same):");
                DisplayValues(p3);
            }

            public static void DisplayValues(Blog p)
            {
            Console.WriteLine($" URL: {p.URL} , PublishDate: {p.PublishDate}");
       
            Console.WriteLine($" Title: { p.Post.Title}");
            }
        }
    } 
