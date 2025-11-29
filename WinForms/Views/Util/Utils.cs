using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms.Views.Util
{
    internal class Utils
    {
        public static bool ValidateStrings(params string[] inputs)
        {
            foreach (var item in inputs)
            {
                if(string.IsNullOrEmpty(item)) 
                    return false;
            }
            return true;
        }

        public static bool ValidateLists<T>(params IEnumerable<T>[] lists)
        {
            foreach (var list in lists)
            {
                if (list == null || list.Count() == 0)
                    return false;
            }
            return true;
        }
    }
}
