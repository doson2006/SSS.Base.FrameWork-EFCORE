using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DependencyInjection;

namespace SSS.FrameWork.Application
{
    /// <summary>RESTful 风格结果集</summary>
    /// <typeparam name="T"></typeparam>
    [SkipScan]
    public class RESTfulResult<T>
    {
        /// <summary>状态码</summary>
        public int? Code { get; set; }

        /// <summary>数据</summary>
        public T Data { get; set; }

        /// <summary>执行成功</summary>
        public bool Succeeded { get; set; }

        /// <summary>错误信息</summary>
        public object Msg { get; set; }

        /// <summary>附加数据</summary>
        public object Extras { get; set; }

        /// <summary>时间戳</summary>
        public long Timestamp { get; set; }
    }
}
