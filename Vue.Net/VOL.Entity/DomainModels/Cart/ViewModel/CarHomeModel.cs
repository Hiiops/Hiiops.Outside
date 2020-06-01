using System.Collections.Generic;

namespace VOL.Entity.DomainModels.Cart.ViewModel
{
    /// <summary>
    /// 小程序首页展示数据
    /// </summary>
    public class CarHomeModel
    {
        /// <summary>
        /// 小程序轮播图
        /// </summary>
        public List<Hiiops_Cart_Banner> Banner { get; set; } = new List<Hiiops_Cart_Banner>();
        /// <summary>
        /// 首页菜单
        /// </summary>
        public List<Hiiops_Cart_Banner> Menus { get; set; } = new List<Hiiops_Cart_Banner>();
        /// <summary>
        /// 二手车
        /// </summary>
        public List<CarList> CarList { get; set; } = new List<CarList>();
        /// <summary>
        /// 联系信息
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// 是否需要登录才能使用
        /// </summary>
        public bool IsLogin { get; set; }
        /// <summary>
        /// APP名
        /// </summary>
        public string AppName { get; set; }

    }

    public class CarList
    {
        /// <summary>
        /// 是否是二手车
        /// </summary>
        public bool Type { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int Total { get; set; }
        /// <summary>
        /// 分类名
        /// </summary>
        public string CategoryName { get; set; }
        /// <summary>
        /// 车辆
        /// </summary>
        public List<Hiiops_Cart> Hiiops_Carts { get; set; } = new List<Hiiops_Cart>();
    }

    /// <summary>
    /// 分类
    /// </summary>
    public class Category
    {
        /// <summary>
        /// id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 父类id
        /// </summary>
        public int PID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

    }

}
