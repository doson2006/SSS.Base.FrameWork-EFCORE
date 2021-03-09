using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DatabaseAccessor;
using Furion.DatabaseAccessor.Extensions;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Furion.FriendlyException;
using Microsoft.AspNetCore.Mvc;
using SSS.FrameWork.Application.SysUser.Services;

namespace SSS.FrameWork.Application.SysUser
{
    public class SysUserAppService : IDynamicApiController, ITransient
    {
        private readonly IRepository<Core.SysUser> _repository;
        private readonly ISysUserSql _sql;
        private readonly ISysUserService _sysUserService;

        public SysUserAppService(IRepository<Core.SysUser> repository, ISysUserSql sql, ISysUserService sysUserService)
        {
            _repository = repository;
            _sql = sql;
            _sysUserService = sysUserService;
        }


       

        /// <summary>
        /// 添加一个用户异步
        /// </summary>
        /// <returns></returns>
        public async Task<Core.SysUser> AddUserAsync()
        {
            var user = await _repository.InsertNowAsync(new Core.SysUser
            {
                CreateUserId = 0,
                CreateUserName = "",
                IsSystem = Core.IsSystemEnum.否,
                Password = "",
                SecretKey = "111",
                State = 0,
                TrueName = "core-test",
                UserName = "core-test"

            });
            return user.Entity;
        }

       
    }
}
