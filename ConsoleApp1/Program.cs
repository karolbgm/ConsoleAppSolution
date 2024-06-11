namespace ConsoleApp1 //Just a name to make it unique
{
    internal class Program
    {
        public static string Name { get; set; } = "Karol"; //Property
        static void Main(string[] args) //Main Method (Function INSIDE a class)
                                        //The system automatically calls the Main Method when we run the program
                                        //Once it's done, program shuts down

        {
            Console.WriteLine($"Hello, {Name}"); //INTERPOLATION

            foreach (string arg in args)
            {
                System.Console.WriteLine($"Hi, {arg}"); //Same as the first one - Console class is inside System namspace. "WriteLine" is a method!
            }
        }

        static void myMethod()
        {
            //DATA TYPES
            int[] scores = { 1, 2, 3, 4 };

        }   
    }
}

/// <summary>
/// 
/// 
/// </summary>

//DATA TYPES
int[] scores = {1,2,3,4};
