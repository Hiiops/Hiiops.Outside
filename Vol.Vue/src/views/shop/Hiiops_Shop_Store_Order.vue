<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Order.js此处编写
 -->
<template>
    <div>
        <view-grid :columns="columns"
                   :detail="detail"
                   :editFormFileds="editFormFileds"
                   :editFormOptions="editFormOptions"
                   :searchFormFileds="searchFormFileds"
                   :searchFormOptions="searchFormOptions"
                   :table="table"
                   :extend="extend">
        </view-grid>
    </div>
</template>

<script>
    import extend from "@/extension/shop/Hiiops_Shop_Store_Order.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Id',
                    footer: "Foots",
                    cnName: '订单管理',
                    name: 'Hiiops_Shop_Store_Order',
                    url: "/Hiiops_Shop_Store_Order/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'订单Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Order_Id',title:'订单号',type:'string',width:120,require:true,align:'left',sortable:true},
                       {field:'UId',title:'用户Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Real_Name',title:'用户姓名',type:'string',width:120,require:true,align:'left'},
                       {field:'User_Phone',title:'用户电话',type:'string',width:90,require:true,align:'left'},
                       {field:'User_Address',title:'详细地址',type:'string',width:180,require:true,align:'left'},
                       {field:'Cart_Id',title:'购物车Id',type:'string',width:220,require:true,align:'left'},
                       {field:'Freight_Price',title:'运费金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Total_Num',title:'订单商品总数',type:'int',width:90,require:true,align:'left'},
                       {field:'Total_Price',title:'订单总价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Total_Postage',title:'邮费',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Pay_Price',title:'实际支付金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Pay_Postage',title:'支付邮费',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Deduction_Price',title:'抵扣金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Coupon_Id',title:'优惠券Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Coupon_Price',title:'优惠券金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'PaId',title:'支付状态',type:'byte',width:90,require:true,align:'left'},
                       {field:'Pay_Time',title:'支付时间',type:'int',width:90,align:'left'},
                       {field:'Pay_Type',title:'支付方式',type:'string',width:120,require:true,align:'left'},
                       {field:'Add_Time',title:'创建时间',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'订单状态（-1 : 申请退款 -2 : 退货成功 0：待发货；1：待收货；2：已收货；3：待评价；-1：已退款）',type:'byte',width:90,require:true,align:'left'},
                       {field:'Refund_Status',title:'0 未退款 1 申请中 2 已退款',type:'byte',width:90,require:true,align:'left'},
                       {field:'Refund_Reason_Wap_Img',title:'退款图片',type:'string',width:220,align:'left'},
                       {field:'Refund_Reason_Wap_Explain',title:'退款用户说明',type:'string',width:220,align:'left'},
                       {field:'Refund_Reason_Time',title:'退款时间',type:'int',width:90,align:'left'},
                       {field:'Refund_Reason_Wap',title:'前台退款原因',type:'string',width:220,align:'left'},
                       {field:'Refund_Reason',title:'不退款的理由',type:'string',width:220,align:'left'},
                       {field:'Refund_Price',title:'退款金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Delivery_Name',title:'快递名称/送货人姓名',type:'string',width:180,align:'left'},
                       {field:'Delivery_Type',title:'发货类型',type:'string',width:120,align:'left'},
                       {field:'Delivery_Id',title:'快递单号/手机号',type:'string',width:180,align:'left'},
                       {field:'Gain_Integral',title:'消费赚取积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Use_Integral',title:'使用积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Back_Integral',title:'给用户退了多少积分',type:'decimal',width:90,align:'left'},
                       {field:'Mark',title:'备注',type:'string',width:220,require:true,align:'left'},
                       {field:'Is_Del',title:'是否删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Unique',title:'唯一Id(md5加密)类似Id',type:'string ',width:120,require:true,align:'left'},
                       {field:'Remark',title:'管理员备注',type:'string',width:220,align:'left'},
                       {field:'Mer_Id',title:'商户Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Mer_Check',title:'Is_Mer_Check',type:'byte',width:90,require:true,align:'left'},
                       {field:'Combination_Id',title:'拼团商品Id0一般商品',type:'int',width:90,align:'left'},
                       {field:'Pink_Id',title:'拼团Id 0没有拼团',type:'int',width:90,require:true,align:'left'},
                       {field:'Cost',title:'成本价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Seckill_Id',title:'秒杀商品Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Bargain_Id',title:'砍价Id',type:'int',width:90,align:'left'},
                       {field:'Verify_Code',title:'核销码',type:'string',width:90,require:true,align:'left'},
                       {field:'Store_Id',title:'门店Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Shipping_Type',title:'配送方式 1=快递 ，2=门店自提',type:'byte',width:90,require:true,align:'left'},
                       {field:'Clerk_Id',title:'店员Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Channel',title:'支付渠道(0微信公众号1微信小程序)',type:'byte',width:90,align:'left'},
                       {field:'Is_Remind',title:'消息提醒',type:'byte',width:90,align:'left'},
                       {field:'Is_System_Del',title:'后台是否删除',type:'byte',width:90,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:90,align:'left',sortable:true}],
                detail: {
                    cnName:"#detailCnName",
                    columns: [],
                    sortName: "",
                    key:""
                }
            };
        }
    };
    export default vueParam;
</script>
