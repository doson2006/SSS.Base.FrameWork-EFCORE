using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS.Util.Extension
{
    public static partial class Extensions
    {
        /// <summary>
        /// 为DataRow的各列赋值
        /// </summary>
        /// <param name="row">要赋值的DataRow对象</param>
        /// <param name="value">要赋的值</param>
        /// <param name="startIndex">赋值列起始位置的索引</param>
        /// <param name="len">从赋值列起始位置的索引开始算，要赋值的列数</param>
        public static void SetValue(this DataRow row, object value, int startIndex, int len)
        {
            int total = row.Table.Columns.Count;
            if (startIndex + 1 > total)
            {
                throw new Exception("赋值起始位置的索引超出了DataTable列的数量。");
            }
            if (len <= 0)
            {
                throw new Exception("赋值的列数必须大于0。");
            }

            int endIndex = Math.Min(total, startIndex + len);
            for (int k = startIndex; k < endIndex; k++)
            {
                row[k] = value;
            }
        }

        /// <summary>
        /// 为DataRow的各列赋值
        /// </summary>
        /// <param name="row">要赋值的DataRow对象</param>
        /// <param name="value">要赋的值</param>
        /// <param name="startIndex">赋值列起始位置的索引</param>
        public static void SetValue(this DataRow row, object value, int startIndex)
        {
            int total = row.Table.Columns.Count;
            if (startIndex + 1 > total)
            {
                throw new Exception("赋值起始位置的索引超出了DataTable列的数量。");
            }

            int endIndex = total;
            for (int k = startIndex; k < endIndex; k++)
            {
                row[k] = value;
            }
        }

        /// <summary>
        /// 为DataRow的各列赋值，从索引0开始赋值
        /// </summary>
        /// <param name="row">要赋值的DataRow对象</param>
        /// <param name="values">要赋的值集合</param>
        public static void SetValues(this DataRow row, IEnumerable<object> values)
        {
            if (values.IsNullOrEmpty()) { return; }
            int total = row.Table.Columns.Count;

            int startIndex = 0;
            int endIndex = Math.Min(total, startIndex + values.Count());

            for (int k = startIndex; k < endIndex; k++)
            {
                row[k] = values.ElementAt(k - startIndex);
            }
        }

        /// <summary>
        /// 为DataRow的各列赋值，从索引0开始赋值
        /// </summary>
        /// <param name="row">要赋值的DataRow对象</param>
        /// <param name="values">要赋的值集合</param>
        /// <param name="startIndex">赋值列起始位置的索引</param>
        public static void SetValues(this DataRow row, IEnumerable<object> values, int startIndex)
        {
            if (values.IsNullOrEmpty()) { return; }
            int total = row.Table.Columns.Count;
            if (startIndex + 1 > total)
            {
                throw new Exception("赋值起始位置的索引超出了DataTable列的数量。");
            }

            int endIndex = Math.Min(total, startIndex + values.Count());

            for (int k = startIndex; k < endIndex; k++)
            {
                row[k] = values.ElementAt(k - startIndex);
            }
        }

        /// <summary>
        /// 为DataRow的各列赋值，从索引0开始赋值
        /// </summary>
        /// <param name="row">要赋值的DataRow对象</param>
        /// <param name="values">要赋的值集合</param>
        /// <param name="startIndex">赋值列起始位置的索引</param>
        public static void SetValues(this DataRow row, IEnumerable<int> values, int startIndex)
        {
            if (values.IsNullOrEmpty()) { return; }
            int total = row.Table.Columns.Count;
            if (startIndex + 1 > total)
            {
                throw new Exception("赋值起始位置的索引超出了DataTable列的数量。");
            }

            int endIndex = Math.Min(total, startIndex + values.Count());

            for (int k = startIndex; k < endIndex; k++)
            {
                row[k] = values.ElementAt(k - startIndex);
            }
        }

        /// <summary>
        /// 为DataRow的各列赋值，从索引0开始赋值
        /// </summary>
        /// <param name="row">要赋值的DataRow对象</param>
        /// <param name="values">要赋的值集合</param>
        /// <param name="startIndex">赋值列起始位置的索引</param>
        public static void SetValues(this DataRow row, IEnumerable<double> values, int startIndex)
        {
            if (values.IsNullOrEmpty()) { return; }
            int total = row.Table.Columns.Count;
            if (startIndex + 1 > total)
            {
                throw new Exception("赋值起始位置的索引超出了DataTable列的数量。");
            }

            int endIndex = Math.Min(total, startIndex + values.Count());

            for (int k = startIndex; k < endIndex; k++)
            {
                row[k] = values.ElementAt(k - startIndex);
            }
        }
    }
}
