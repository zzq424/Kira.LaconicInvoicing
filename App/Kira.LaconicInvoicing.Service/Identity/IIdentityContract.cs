﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using Kira.LaconicInvoicing.Identity.Dtos;
using Kira.LaconicInvoicing.Identity.Entities;

using OSharp.Data;


namespace Kira.LaconicInvoicing.Service.Identity
{
    /// <summary>
    /// 业务契约：身份认证模块
    /// </summary>
    public interface IIdentityContract
    {
        #region 用户信息业务

        /// <summary>
        /// 获取 用户信息查询数据集
        /// </summary>
        IQueryable<User> Users { get; }

        #endregion

        #region 角色信息业务

        /// <summary>
        /// 获取 角色信息查询数据集
        /// </summary>
        IQueryable<Role> Roles { get; }

        #endregion

        #region 用户角色信息业务

        /// <summary>
        /// 获取 用户角色信息查询数据集
        /// </summary>
        IQueryable<UserRole> UserRoles { get; }

        /// <summary>
        /// 检查用户角色信息信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的用户角色信息编号</param>
        /// <returns>用户角色信息是否存在</returns>
        Task<bool> CheckUserRoleExists(Expression<Func<UserRole, bool>> predicate, Guid id = default(Guid));

        /// <summary>
        /// 更新用户角色信息
        /// </summary>
        /// <param name="dtos">用户角色信息集合</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> UpdateUserRoles(params UserRoleInputDto[] dtos);

        /// <summary>
        /// 设置用户的角色
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <param name="roleIds">角色编号集合</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> SetUserRoles(int userId, int[] roleIds);

        #endregion

        #region 身份认证

        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="dto">注册信息</param>
        /// <param name="service"></param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult<User>> Register(RegisterDto dto, IServiceProvider service);

        /// <summary>
        /// 使用账号登录
        /// </summary>
        /// <param name="dto">登录信息</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult<User>> Login(LoginDto dto);

        /// <summary>
        /// 账号退出
        /// </summary>
        /// <param name="userId">用户编号</param>
        /// <returns>业务操作结果</returns>
        Task<OperationResult> Logout(int userId);

        #endregion
    }
}