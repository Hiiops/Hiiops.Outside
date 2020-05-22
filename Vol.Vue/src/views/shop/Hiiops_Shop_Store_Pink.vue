<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Pink.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Pink.js";
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
                    cnName: '开团列表',
                    name: 'Hiiops_Shop_Store_Pink',
                    url: "/Hiiops_Shop_Store_Pink/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Status',title:'状态1进行中2已完成3未完成',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Refund',title:'是否退款 0未退款 1已退款',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Tpl',title:'是否发送模板消息0未发送1已发送',type:'byte',width:90,require:true,align:'left'},
                       {field:'K_Id',title:'团长Id 0为团长',type:'int',width:80,require:true,align:'left'},
                       {field:'Stop_Time',title:'Stop_Time',type:'string',width:90,require:true,align:'left'},
                       {field:'Add_Time',title:'开始时间',type:'string',width:90,require:true,align:'left'},
                       {field:'Price',title:'拼团商品单价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'People',title:'拼图总人数',type:'int',width:80,require:true,align:'left'},
                       {field:'PId',title:'商品Id',type:'int',width:80,require:true,align:'left'},
                       {field:'CId',title:'拼团商品Id',type:'int',width:80,require:true,align:'left'},
                       {field:'Total_Price',title:'购买总金额',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Total_Num',title:'购买商品个数',type:'int',width:80,require:true,align:'left'},
                       {field:'Order_Id_Key',title:'订单Id  数据库',type:'int',width:80,require:true,align:'left'},
                       {field:'Order_Id',title:'订单Id 生成',type:'string',width:120,require:true,align:'left'},
                       {field:'UId',title:'用户Id',type:'int',width:80,require:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,align:'left',sortable:true}],
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
