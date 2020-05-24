let viewgird = [
   {
        path: '/Sys_Log',
        name: 'sys_Log',
        component: () => import('@/views/system/Sys_Log.vue')
    }
    ,{
        path: '/Sys_User',
        name: 'Sys_User',
        component: () => import('@/views/system/Sys_User.vue')
    }    ,{
        path: '/Sys_Dictionary',
        name: 'Sys_Dictionary',
        component: () => import('@/views/system/Sys_Dictionary.vue')
    }    ,{
        path: '/Sys_Role',
        name: 'Sys_Role',
        component: () => import('@/views/system/Sys_Role.vue')
    }
    ,{
        path: '/Sys_DictionaryList',
        name: 'Sys_DictionaryList',
        component: () => import('@/views/system/Sys_DictionaryList.vue')
    }
    ,{
        path: '/SellOrder',
        name: 'SellOrder',
        component: () => import('@/views/order/SellOrder.vue')
    }    ,{
      path: '/vSellOrderImg',
      name: 'vSellOrderImg',
      component: () => import('@/views/order/vSellOrderImg.vue')
      }     ,{
        path: '/App_Appointment',
        name: 'App_Appointment',
        component: () => import('@/views/order/App_Appointment.vue')
    }    ,{
        path: '/App_TransactionAvgPrice',
        name: 'App_TransactionAvgPrice',
        component: () => import('@/views/appmanager/App_TransactionAvgPrice.vue')
    }    ,{
        path: '/App_Expert',
        name: 'App_Expert',
        component: () => import('@/views/appmanager/App_Expert.vue')
    }    ,{
        path: '/App_Transaction',
        name: 'App_Transaction',
        component: () => import('@/views/appmanager/App_Transaction.vue')
    }    ,{
        path: '/App_ReportPrice',
        name: 'App_ReportPrice',
        component: () => import('@/views/appmanager/App_ReportPrice.vue')
    }    ,{
        path: '/App_News',
        name: 'App_News',
        component: () => import('@/views/appmanager/App_News.vue')
    }    ,{
        path: '/Hiiops_Cart',
        name: 'Hiiops_Cart',
        component: () => import('@/views/cart/Hiiops_Cart.vue')
    }    ,{
        path: '/Hiiops_Cart_Brand',
        name: 'Hiiops_Cart_Brand',
        component: () => import('@/views/cart/Hiiops_Cart_Brand.vue')
    }    ,{
        path: '/Hiiops_Cart_Category',
        name: 'Hiiops_Cart_Category',
        component: () => import('@/views/cart/Hiiops_Cart_Category.vue')
    }    ,{
        path: '/Hiiops_Cart_System_Config',
        name: 'Hiiops_Cart_System_Config',
        component: () => import('@/views/cart/Hiiops_Cart_System_Config.vue')
    }    ,{
        path: '/Hiiops_Cart_Banner',
        name: 'Hiiops_Cart_Banner',
        component: () => import('@/views/cart/Hiiops_Cart_Banner.vue')
    }    ,{
        path: '/Hiiops_Cart_Seller_PV_Count',
        name: 'Hiiops_Cart_Seller_PV_Count',
        component: () => import('@/views/cart/Hiiops_Cart_Seller_PV_Count.vue')
    }    ,{
        path: '/Hiiops_Cart_Seller_Collection',
        name: 'Hiiops_Cart_Seller_Collection',
        component: () => import('@/views/cart/Hiiops_Cart_Seller_Collection.vue')
    }    ,{
        path: '/Hiiops_Cart_SellerOrder',
        name: 'Hiiops_Cart_SellerOrder',
        component: () => import('@/views/cart/Hiiops_Cart_SellerOrder.vue')
    }    ,{
        path: '/Hiiops_Cart_SellerUser',
        name: 'Hiiops_Cart_SellerUser',
        component: () => import('@/views/cart/Hiiops_Cart_SellerUser.vue')
    }    ,{
        path: '/Hiiops_Cart_Coupon',
        name: 'Hiiops_Cart_Coupon',
        component: () => import('@/views/cart/Hiiops_Cart_Coupon.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Product',
        name: 'Hiiops_Shop_Store_Product',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Product.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Category',
        name: 'Hiiops_Shop_Store_Category',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Category.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Product_Reply',
        name: 'Hiiops_Shop_Store_Product_Reply',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Product_Reply.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Product_Attr',
        name: 'Hiiops_Shop_Store_Product_Attr',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Product_Attr.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Order',
        name: 'Hiiops_Shop_Store_Order',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Order.vue')
    }    ,{
        path: '/Hiiops_Shop_User',
        name: 'Hiiops_Shop_User',
        component: () => import('@/views/shop/Hiiops_Shop_User.vue')
    }    ,{
        path: '/Hiiops_Shop_User_Level',
        name: 'Hiiops_Shop_User_Level',
        component: () => import('@/views/shop/Hiiops_Shop_User_Level.vue')
    }    ,{
        path: '/Hiiops_Shop_User_Group',
        name: 'Hiiops_Shop_User_Group',
        component: () => import('@/views/shop/Hiiops_Shop_User_Group.vue')
    }    ,{
        path: '/Hiiops_Shop_User_Label',
        name: 'Hiiops_Shop_User_Label',
        component: () => import('@/views/shop/Hiiops_Shop_User_Label.vue')
    }    ,{
        path: '/Hiiops_Shop_User_Extract',
        name: 'Hiiops_Shop_User_Extract',
        component: () => import('@/views/shop/Hiiops_Shop_User_Extract.vue')
    }    ,{
        path: '/Hiiops_Shop_User_Recharge',
        name: 'Hiiops_Shop_User_Recharge',
        component: () => import('@/views/shop/Hiiops_Shop_User_Recharge.vue')
    }    ,{
        path: '/Hiiops_Shop_User_Bill',
        name: 'Hiiops_Shop_User_Bill',
        component: () => import('@/views/shop/Hiiops_Shop_User_Bill.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Coupon',
        name: 'Hiiops_Shop_Store_Coupon',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Coupon.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Coupon_Issue',
        name: 'Hiiops_Shop_Store_Coupon_Issue',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Coupon_Issue.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Coupon_Issue_User',
        name: 'Hiiops_Shop_Store_Coupon_Issue_User',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Coupon_Issue_User.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Bargain',
        name: 'Hiiops_Shop_Store_Bargain',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Bargain.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Combination',
        name: 'Hiiops_Shop_Store_Combination',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Combination.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Pink',
        name: 'Hiiops_Shop_Store_Pink',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Pink.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Seckill',
        name: 'Hiiops_Shop_Store_Seckill',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Seckill.vue')
    }    ,{
        path: '/Hiiops_Shop_Article',
        name: 'Hiiops_Shop_Article',
        component: () => import('@/views/shop/Hiiops_Shop_Article.vue')
    }    ,{
        path: '/Hiiops_Shop_Article_Category',
        name: 'Hiiops_Shop_Article_Category',
        component: () => import('@/views/shop/Hiiops_Shop_Article_Category.vue')
    }    ,{
        path: '/Hiiops_Shop_Article_Content',
        name: 'Hiiops_Shop_Article_Content',
        component: () => import('@/views/shop/Hiiops_Shop_Article_Content.vue')
    }    ,{
        path: '/Hiiops_Shop_Store_Service',
        name: 'Hiiops_Shop_Store_Service',
        component: () => import('@/views/shop/Hiiops_Shop_Store_Service.vue')
    }    ,{
        path: '/Hiiops_Shop_System_Config',
        name: 'Hiiops_Shop_System_Config',
        component: () => import('@/views/shop/Hiiops_Shop_System_Config.vue')
    }    ,{
        path: '/Hiiops_Shop_Wechat_Key',
        name: 'Hiiops_Shop_Wechat_Key',
        component: () => import('@/views/shop/Hiiops_Shop_Wechat_Key.vue')
    }    ,{
        path: '/Hiiops_Shop_Express',
        name: 'Hiiops_Shop_Express',
        component: () => import('@/views/shop/Hiiops_Shop_Express.vue')
    }    ,{
        path: '/Hiiops_Shop_Shipping_Templates',
        name: 'Hiiops_Shop_Shipping_Templates',
        component: () => import('@/views/shop/Hiiops_Shop_Shipping_Templates.vue')
    }]
export default viewgird
