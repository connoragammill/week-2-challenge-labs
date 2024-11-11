namespace week_2_challenge_labs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature in Farenheit:");
            int temp = int.Parse(Console.ReadLine());
            //If lower than 10, display Freezing weather
            if (temp <= 10) 
            { 
                Console.WriteLine("Freezing weather"); 
            } 
            //If its 11-20, display Very cold weather
            else if (temp >= 11 && temp <= 20) 
            { 
                Console.WriteLine("Very cold weather"); 
            }
            //If its 21-35, display Cold weather
            else if (temp >= 21 && temp <= 35) 
            { 
                Console.WriteLine("Cold weather"); 
            }
            //If its 36-50, display Normal in weather
            else if (temp >= 36 && temp <= 50) 
            { 
                Console.WriteLine("Normal in weather"); 
            } 
            //If its 51-65, display Its hot
            else if (temp >= 51 && temp <= 65) 
            { 
                Console.WriteLine("It's hot"); 
            }
            //If its 66-80, display Its very hot
            else if (temp >= 66 && temp <= 80) 
            { 
                Console.WriteLine("It's very hot"); 
            } 
            //If the user puts a number above 80, display Temperature outside specified range
            else 
            { 
                Console.WriteLine("Temperature outside specified range."); 
            }
        }
    }
}
