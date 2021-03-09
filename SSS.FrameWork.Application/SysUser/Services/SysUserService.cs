using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Furion.FriendlyException;

namespace SSS.FrameWork.Application.SysUser.Services
{
    public class SysUserService:ISysUserService, ITransient
    {
        private readonly IRepository<Core.SysUser> _repository;

        public SysUserService(IRepository<Core.SysUser> repository)
        {
            _repository = repository;
        }

        [UnitOfWork]
        public async Task BatchAddUser()
        {
            var user = await _repository.InsertNowAsync(new Core.SysUser
            {
                CreateUserId = 0,
                CreateUserName = "",
                IsSystem = Core.IsSystemEnum.否,
                Password = "",
                SecretKey = "111",
                State = 0,
                TrueName = "core-test" + System.Guid.NewGuid(),
                UserName = "core-test"

            });
           

            var use1r = await _repository.InsertNowAsync(new Core.SysUser
            {
                CreateUserId = 0,
                CreateUserName = "",
                IsSystem = Core.IsSystemEnum.否,
                Password = "",
                SecretKey = "111",
                State = 0,
                TrueName = "core-test"+System.Guid.NewGuid(),
                UserName = "core-test"

            });

            throw Oops.Oh(ErrorCodes.z1000);
        }
    }
}
