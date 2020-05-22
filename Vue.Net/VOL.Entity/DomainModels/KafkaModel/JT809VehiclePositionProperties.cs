using System;
using System.Collections.Generic;
using System.Text;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels.KafkaModel
{
    public class JT809VehiclePositionProperties
    {

        public JT809VehiclePositionProperties() { }
        //
        // 摘要:
        //     海拔高度，单位为米（m）。
        public ushort Altitude { get; set; }
        //
        // 摘要:
        //     方向，0-359，单位为度（。），正北为 0，顺时针。
        public ushort Direction { get; set; }
        //
        // 摘要:
        //     车辆当前总里程数，值车辆上传的行车里程数。单位单位为千米（km）
        public uint Vec3 { get; set; }
        //
        // 摘要:
        //     行驶记录速度，指车辆行驶记录设备上传的行车速度 信息，为必填项。单位为千米每小时（km/h）。
        public ushort Vec2 { get; set; }
        //
        // 摘要:
        //     速度，指卫星定位车载终端设备上传的行车速度信息，为必填项。单位为千米每小时（km/h）。
        public ushort Vec1 { get; set; }
        //
        // 摘要:
        //     纬度，单位为 1*10^-6 度。
        public uint Lat { get; set; }
        //
        // 摘要:
        //     车辆状态，二进制表示，B31B30B29。。。。。。B2B1B0.具体定义按照 JT/T808-2011 中表 17 的规定
        public uint State { get; set; }
        //
        // 摘要:
        //     经度，单位为 1*10^-6 度。
        public uint Lon { get; set; }
        //
        // 摘要:
        //     分
        public byte Minute { get; set; }
        //
        // 摘要:
        //     时
        public byte Hour { get; set; }
        //
        // 摘要:
        //     年
        public ushort Year { get; set; }
        //
        // 摘要:
        //     月
        public byte Month { get; set; }
        //
        // 摘要:
        //     日
        public byte Day { get; set; }
        //
        // 摘要:
        //     该字段标识传输的定位信息是否使用国家测绘局批准的地图保密插件进行加密。
        public JT809_VehiclePositionEncrypt Encrypt { get; set; }
        //
        // 摘要:
        //     秒
        public byte Second { get; set; }
        //
        // 摘要:
        //     报警状态，二进制表示，0 标识正常，1 表示报警： B31B30B29 。。。。。。 B2B1B0.具 体 定 义 按 照JT/T808-2011 中表
        //     18 的规定
        public uint Alarm { get; set; }
    }
}
