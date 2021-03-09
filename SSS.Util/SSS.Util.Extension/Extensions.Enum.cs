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
        /// 将指定枚举的内容转换成int集合
        /// </summary>
        /// <param name="valueEnum"></param>
        /// <returns></returns>
        public static List<int> EnumToInts(this Enum valueEnum)
        {
            return Enum.GetValues(valueEnum.GetType()).Cast<int>().ToList();
        }

        public static List<dynamic> EnumToList(this Enum valueEnum)
        {
            List<dynamic> listEnter = new List<dynamic>();
            foreach (int value in Enum.GetValues(valueEnum.GetType()))
                listEnter.Add(new { Id = value, Name = Enum.GetName(valueEnum.GetType(), value) });
            return listEnter;
        }

        public static List<EnumList> EnumToListGener(this Enum valueEnum)
        {
            List<EnumList> listEnter = new List<EnumList>();
            foreach (int value in Enum.GetValues(valueEnum.GetType()))
                listEnter.Add(new EnumList {Id = value, Name = Enum.GetName(valueEnum.GetType(), value)});
            return listEnter;
        }
    }

    public class EnumList
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
