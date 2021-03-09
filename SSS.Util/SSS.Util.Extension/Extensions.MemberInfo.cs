using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SSS.Util.Extension
{
    public static partial class Extensions
    {
        /// <summary>
        ///  获取成员元数据的Description特性描述信息
        /// </summary>
        /// <param name="member">成员元数据对象</param>
        /// <param name="inherit">是否搜索成员的继承链以查找描述特性</param>
        /// <returns>返回Description特性描述信息，如不存在则返回如不存在则返回空字符串</returns>
        public static string ToDescription(this MemberInfo member, bool inherit = false)
        {
            DescriptionAttribute desc = member.GetAttribute<DescriptionAttribute>(inherit);
            return desc == null ? "" : desc.Description;
        }

        /// <summary>
        ///  获取成员元数据的Description特性描述信息
        /// </summary>
        /// <param name="member">成员元数据对象</param>
        /// <param name="defaultValue">如Description特性不存在则返回指定默认值</param>
        /// <param name="inherit">是否搜索成员的继承链以查找描述特性</param>
        /// <returns>返回Description特性描述信息</returns>
        public static string ToDescription(this MemberInfo member, string defaultValue, bool inherit = false)
        {
            DescriptionAttribute desc = member.GetAttribute<DescriptionAttribute>(inherit);
            return desc == null ? defaultValue : desc.Description;
        }

        /// <summary>
        /// 从类型成员获取指定Attribute特性
        /// </summary>
        /// <typeparam name="T">Attribute特性类型</typeparam>
        /// <param name="memberInfo">成员元数据对象</param>
        /// <param name="inherit">是否从继承中查找</param>
        /// <returns>存在返回第一个，不存在返回null</returns>
        public static T GetAttribute<T>(this MemberInfo memberInfo, bool inherit) where T : Attribute
        {
            return memberInfo.GetCustomAttributes(typeof(T), inherit).FirstOrDefault() as T;
        }
    }
}
