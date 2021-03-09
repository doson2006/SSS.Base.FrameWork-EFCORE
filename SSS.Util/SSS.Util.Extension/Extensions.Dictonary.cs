using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS.Util.Extension
{
    public static partial class Extensions
    {
        public static string ToSortUrlParamString<T1, T2>(this IDictionary<T1, T2> dic)
        {
               var dicSort = from objDic in dic orderby objDic.Value ascending select objDic;
            string str = dicSort.Aggregate(string.Empty, (current, i) => current + $"{i.Key}={i.Value}&");
            return str.TrimEnd('&');
        }
    }
}
