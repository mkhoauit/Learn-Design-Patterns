using LearnMediator.Classes;
using System;

namespace LearnMediator
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor = new Doctor();
            Nurse nurse = new Nurse();
            new ConcreteMediator(doctor, nurse);


            Console.WriteLine("Do you want to check your health? [press a]");
            Console.WriteLine("Emergency Surgery? [press b]");
            Console.WriteLine("Minor Surgery? [press c]");
            string input = Convert.ToString(Console.ReadLine()) ;
            if (input != "a" && input != "b" && input!="c"&& input != "A" && input != "B" && input != "C")
            {

                Console.WriteLine("Error!!");
                Console.WriteLine("End.");
            }
            else
            {
                if(input == "a" || input == "A") 
                {
                    doctor.Examining();
                    Console.WriteLine("End.");

                }

                if (input == "b" || input == "B")
                {
                    
                    nurse.Support();
                    Console.WriteLine("End.");

                }

                if (input == "c" || input == "C")
                {
                    nurse.BodyTemperature();
                    Console.WriteLine("End.");

                }

                

            }
            
           
        }
    }
}
