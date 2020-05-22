<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_User_Extract.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_User_Extract.js";
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
                    cnName: '提现申请',
                    name: 'Hiiops_Shop_User_Extract',
                    url: "/Hiiops_Shop_User_Extract/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'Id',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ModifyID',title:'审核ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Wechat',title:'微信号',type:'string',width:90,align:'left'},
                       {field:'Status',title:'-1 未通过 0 审核中 1 已提现',type:'byte',width:90,align:'left'},
                       {field:'Fail_Time',title:'失败时间',type:'int',width:80,align:'left'},
                       {field:'Fail_Msg',title:'无效原因',type:'string',width:220,align:'left'},
                       {field:'Balance',title:'金额',type:'decimal',width:90,align:'left'},
                       {field:'Mark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'Extract_Price',title:'提现金额',type:'decimal',width:90,align:'left'},
                       {field:'Alipay_Code',title:'支付宝账号',type:'string',width:180,align:'left'},
                       {field:'Bank_Address',title:'开户地址',type:'string',width:220,align:'left'},
                       {field:'Bank_Code',title:'银行卡',type:'string',width:120,align:'left'},
                       {field:'Extract_Type',title:'bank = 银行卡 alipay = 支付宝wx=微信',type:'string',width:120,align:'left'},
                       {field:'Real_Name',title:'名称',type:'string',width:180,align:'left'},
                       {field:'UId',title:'用户ID',type:'int',width:80,align:'left'},
                       {field:'Modifier',title:'审核人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'审核时间',type:'datetime',width:150,align:'left',sortable:true}],
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
