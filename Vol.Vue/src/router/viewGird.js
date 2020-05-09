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
    }]
export default viewgird
