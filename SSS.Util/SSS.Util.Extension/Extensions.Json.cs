using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace SSS.Util.Extension
{
    public static partial class Extensions
    {
        /// <summary>
        /// json.net序列化
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static object ToJson(this string Json)
        {
            return Json == null ? null : JsonConvert.DeserializeObject(Json);
        }
        /// <summary>
        /// json.net序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd HH:mm:ss" };
            return JsonConvert.SerializeObject(obj, timeConverter);
        }
        /// <summary>
        /// json.net序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="datetimeformats"></param>
        /// <returns></returns>
        public static string ToJson(this object obj, string datetimeformats)
        {
            var timeConverter = new IsoDateTimeConverter { DateTimeFormat = datetimeformats };
            return JsonConvert.SerializeObject(obj, timeConverter);
        }
        /// <summary>
        /// json.net反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string Json)
        {
            return Json == null ? default(T) : JsonConvert.DeserializeObject<T>(Json);
        }
        /// <summary>
        /// json.net反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static IEnumerable<T> ToIEnumerable<T>(this string Json)
        {
            return Json == null ? null : JsonConvert.DeserializeObject<IEnumerable<T>>(Json);
        }
        /// <summary>
        /// json.net反序列化
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static DataTable ToTable(this string Json)
        {
            return Json == null ? null : JsonConvert.DeserializeObject<DataTable>(Json);
        }
        /// <summary>
        /// json.net反序列化
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static JObject ToJObject(this string Json)
        {
            return Json == null ? JObject.Parse("{}") : JObject.Parse(Json.Replace("&nbsp;", ""));
        }
    }
}
