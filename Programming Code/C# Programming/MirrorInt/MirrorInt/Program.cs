using MirrorInt.Helpers;

namespace MirrorInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 12345;
            string res = Globe.Mirror(x);
            Console.WriteLine(res);
        }
    }
}
