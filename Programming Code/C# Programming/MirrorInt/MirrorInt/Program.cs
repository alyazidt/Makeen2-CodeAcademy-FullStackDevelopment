using MirrorInt.Helpers;

namespace MirrorInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12345;
            Console.WriteLine($"The Reverse of the number : {x} = {Globe.MirrorInt(x)}");


            string y = "alyazid";
            Console.WriteLine($"\nThe Reverse of the string : {y} = {Globe.MirrorString(y)}");
        }
    }
}
