using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovies.Client.Helpers
{
    public class StringUtilities
    {
        public static string GetClassName(int count)
        {
            return count >= 0 ? "text-success" : "text-danger";
        }
    }
}
