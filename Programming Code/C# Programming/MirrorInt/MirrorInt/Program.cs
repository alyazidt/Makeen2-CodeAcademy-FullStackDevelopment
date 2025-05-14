using MirrorInt.Helpers;

namespace MirrorInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12345;
            Console.WriteLine(Globe.Mirror(x));


            string y = "alyazid";
            Console.WriteLine(Globe.MirrorInt(y));
        }
    }
}
