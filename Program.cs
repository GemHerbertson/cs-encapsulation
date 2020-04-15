using System;

namespace cSharpEncapsulation
{
    class AreaClass
    {
        public double width;
        public double length;
        public double age = 35;
        public string userInput;
        public double Area()
        {
            return width * length;
        }

        public void InformationDisplayed() 
        {
            Console.WriteLine("Width = {0}", width);
            Console.WriteLine("Length = {0}", length);
            Console.WriteLine("Our area is {0}", Area());
        }

        public void UserDetails()
        {
            double myDouble = 44.0;
            int myInt = 44;
            bool myBool = true;

            // Console.WriteLine("Please enter your user details: ");
            // userInput = Console.ReadLine();
            // if (Convert.ToDouble(userInput) == age) 
            // {
            //     Console.WriteLine("Woah, it matches");
            // }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AreaClass myShape = new AreaClass(); // new instance so it can be called/used
            myShape.width = 12.94;
            myShape.length = 6.87;
            myShape.InformationDisplayed();
            myShape.UserDetails();
            Console.ReadKey();
        }
    }
}
