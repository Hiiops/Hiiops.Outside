<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_User_Recharge.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_User_Recharge.js";
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
                    cnName: '充值记录',
                    name: 'Hiiops_Shop_User_Recharge',
                    url: "/Hiiops_Shop_User_Recharge/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'UId',title:'充值用户UId',type:'int',width:90,align:'left',sortable:true},
                       {field:'Order_Id',title:'订单号',type:'string',width:120,align:'left'},
                       {field:'Price',title:'充值金额',type:'decimal',width:90,align:'left'},
                       {field:'Give_Price',title:'购买赠送金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Recharge_Type',title:'充值类型',type:'string',width:120,align:'left'},
                       {field:'PaId',title:'是否充值',type:'byte',width:90,align:'left'},
                       {field:'Pay_Time',title:'充值支付时间',type:'int',width:90,align:'left'},
                       {field:'Add_Time',title:'充值时间',type:'int',width:90,align:'left'},
                       {field:'Refund_Price',title:'退款金额',type:'decimal',width:90,align:'left'},
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
