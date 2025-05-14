using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MirrorInt.Helpers
{
    public static class Globe
    {
        // Integr Mirror
        public static string MirrorInt(int x)
        {
            var str = x.ToString().ToArray();
            Array.Reverse(str);
            var result = new string(str);
            return result;

        }


        // String Mirror
        public static string MirrorString(string x)
        {
            var str1 = x.ToCharArray();
            Array.Reverse(str1);
            return new string(str1);
        }

    }
}
