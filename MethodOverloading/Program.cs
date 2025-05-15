namespace MethodOverloading
{
    public class Program
    {

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        static string Add(int num1, int num2, bool info)
        {
            return info == true && num1 + num2 == 1 ? $"{num1 + num2} dollar" :
                info == true ? $"{num1 + num2} dollars" : 
                $"{num1 + num2}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine($" {Add(5, 7)}\n {Add(5.6, 6.7)}\n {Add(3, 4, true)}\n " +
                              $"{Add(1, 0, true)}\n {Add(78, 89, false)}");
        }
    }
}
