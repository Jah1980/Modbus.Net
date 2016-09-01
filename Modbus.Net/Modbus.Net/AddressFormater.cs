﻿using System;

namespace Modbus.Net
{
    /// <summary>
    /// 地址编码器
    /// </summary>
    public abstract class AddressFormater
    {
        public abstract string FormatAddress(string area, int address);
        /// <summary>
        /// 编码地址
        /// </summary>
        /// <param name="area">地址所在的数据区域</param>
        /// <param name="address">地址</param>
        /// <param name="subAddress">子地址</param>
        /// <returns>编码后的地址</returns>
        public abstract string FormatAddress(string area, int address, int subAddress);
    }

    /// <summary>
    /// 基本的地址编码器
    /// </summary>
    public class AddressFormaterBase : AddressFormater
    {
        public override string FormatAddress(string area, int address)
        {
            return area + ":" + address;
        }

        public override string FormatAddress(string area, int address, int subAddress)
        {
            return area + ":" + address + ":" + subAddress;
        }
    }
}