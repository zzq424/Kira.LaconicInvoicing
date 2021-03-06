﻿using OSharp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kira.LaconicInvoicing.Sale.Dtos
{
    public class SaleOrderInputDto: IInputDto<Guid>
    {
        /// <summary>
        /// 获取或设置 销售单Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 获取或设置 销售单编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 18)]
        public string Number { get; set; }

        /// <summary>
        /// 获取或设置 客户编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 18)]
        public string CustomerNumber { get; set; }

        /// <summary>
        /// 获取或设置 客户名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string CustomerName { get; set; }

        /// <summary>
        /// 获取或设置 发货人联系方式
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string ConsignorContact { get; set; }

        /// <summary>
        /// 获取或设置 发货人
        /// </summary>
        [StringLength(maximumLength: 255)]
        public string Consignor { get; set; }

        /// <summary>
        /// 获取或设置 发货地址
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string SourceAddress { get; set; }

        /// <summary>
        /// 获取或设置 收获
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string DestAddress { get; set; }

        /// <summary>
        /// 获取或设置 仓库编号
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string WarehouseNumber { get; set; }

        /// <summary>
        /// 获取或设置 仓库名称
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string WarehouseName { get; set; }

        /// <summary>
        /// 获取或设置 收货人
        /// </summary>
        [StringLength(maximumLength: 255)]
        public string Consignee { get; set; }

        /// <summary>
        /// 获取或设置 收货人联系方式
        /// </summary>
        [Required]
        [StringLength(maximumLength: 255)]
        public string ConsigneeContact { get; set; }

        /// <summary>
        /// 获取或设置 运费
        /// </summary>
        public double? Freight { get; set; }

        /// <summary>
        /// 获取或设置 合计金额
        /// </summary>
        public double TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置 合计数量
        /// </summary>
        public int TotalQuantity { get; set; }

        /// <summary>
        /// 获取或设置 实收金额
        /// </summary>
        public double AmountPaid { get; set; }

        /// <summary>
        /// 获取或设置 支付金额
        /// </summary>
        public string PayWay { get; set; }

        /// <summary>
        /// 获取或设置 销售单状态
        /// </summary>
        public SaleOrderStatus Status { get; set; }

        /// <summary>
        /// 获取或设置 销售单备注
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 获取或设置 操作员
        /// </summary>
        [StringLength(maximumLength: 255)]
        public string Operator { get; set; }

        /// <summary>
        /// 获取或设置 最近更新时间
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// 获取或设置 销售单项目
        /// </summary>
        [Required]
        public SaleOrderItemInputDto[] Items { get; set; }
    }
}
