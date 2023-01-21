using System.Reflection;

namespace SP_HW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Problem1
            string dllPath = "MyLibrarySP_HW6.1.dll";
            Assembly assembly = Assembly.LoadFrom(dllPath);
            Type myClassType = assembly.GetType("MyLibrarySP_HW6._1.MessageHelper");
            MethodInfo showInfoMessageMethod = myClassType.GetMethod("ShowInfo", BindingFlags.Static | BindingFlags.Public);
            showInfoMessageMethod.Invoke(null, new object[] { "Hello World!" });

            //Problem2
            Assembly dll = Assembly.LoadFrom("MyLibrarySP_HW6.1.dll");   
            Type leapYearType = dll.GetType("MyLibrarySP_HW6._2.LeapYear");   
            MethodInfo leapYearMethod = leapYearType.GetMethod("IsLeapYear");   
            object result = leapYearMethod.Invoke(null, new object[] { 2000 });

            //Problem3
            int a = 5, b = 10, c = 2;
           
            Assembly mathLibrary = Assembly.LoadFrom("MyLibrarySP_HW6.3.dll");          
            Type mathFunctionsType = mathLibrary.GetType("MyLibrarySP_HW6._3.MathFunctions");          
            MethodInfo maximumMethod = mathFunctionsType.GetMethod("Maximum");        
            int max = (int)maximumMethod.Invoke(null, new object[] { a, b, c });          
            MethodInfo minimumMethod = mathFunctionsType.GetMethod("Minimum");        
            int min = (int)minimumMethod.Invoke(null, new object[] { a, b, c });            
            MethodInfo sumMethod = mathFunctionsType.GetMethod("Sum");
            int sum = (int)sumMethod.Invoke(null, new object[] { a, b, c });

            //Problem4

            Assembly mathLibrary2 = Assembly.LoadFrom("MyLibrarySP_HW6.4.dll");
            Type mathFunctionsType2 = mathLibrary.GetType("MyLibrarySP_HW6._3.MathFunctions");
            MethodInfo factorialMethod = mathFunctionsType.GetMethod("Factorial");

            int inputNumber = 5;
            long result2 = (long)factorialMethod.Invoke(null, new object[] { inputNumber });
            Console.WriteLine("Factorial of {0} is: {1}", inputNumber, result);

             


        }
    }
}