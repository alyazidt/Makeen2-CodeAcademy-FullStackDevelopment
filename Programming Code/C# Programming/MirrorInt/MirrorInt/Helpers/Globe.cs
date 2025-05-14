using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorInt.Helpers
{
    public static class Globe
    {

        public static string Mirror(int x)
        {
            var str = x.ToString().ToArray();
            Array.Reverse(str);
            var result = new string(str);
            return result;






        }


        public static string MirrorInt(string x)
        {
            var str1 = x.ToCharArray();
            Array.Reverse(str1);
            return new string(str1);
        }

    }
}
