using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS.Util.Extension
{
    public static partial class Extensions
    {
        /// <summary>
        /// 判断指定类型是否为数值类型
        /// </summary>
        /// <param name="_this">要检查的类型</param>
        /// <returns>是否是数值类型</returns>
        public static bool IsNumeric(this Type _this)
        {
            return _this == typeof(Byte)
                || _this == typeof(Int16)
                || _this == typeof(Int32)
                || _this == typeof(Int64)
                || _this == typeof(SByte)
                || _this == typeof(UInt16)
                || _this == typeof(UInt32)
                || _this == typeof(UInt64)
                || _this == typeof(double)
                || _this == typeof(double)
                || _this == typeof(Single);
        }
    }
}
