using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DatabaseAccessor;

namespace SSS.FrameWork.Application.SysUser.Services
{
    public interface ISysUserSql: ISqlDispatchProxy
    {
        // 执行sql并传入参数，基元类型
        [SqlExecute("select * from Sys_user where true_name = @name")]
        DataTable GetPerson(string name);
    }
}
