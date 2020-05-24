<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_Seller_PV_Count.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart_Seller_PV_Count.js";
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
                    cnName: '访问统计',
                    name: 'Hiiops_Cart_Seller_PV_Count',
                    url: "/Hiiops_Cart_Seller_PV_Count/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {"Phone":"","Remark":""},
                editFormOptions: [[{"title":"电话","field":"Phone","type":"phone"},
                               {"title":"备注","field":"Remark","type":"textarea"}]],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'SellerUserName',title:'姓名',type:'string ',width:220,align:'left',sortable:true},
                       {field:'Phone',title:'电话',type:'string ',width:90,align:'left'},
                       {field:'SellerOrderId',title:'SellerOrderId',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CartName',title:'车辆名称',type:'string ',width:220,align:'left'},
                       {field:'CartId',title:'车辆ID',type:'int',width:80,require:true,align:'left'},
                       {field:'Count',title:'次数',type:'int',width:80,require:true,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:90,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,hidden:true,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,hidden:true,align:'left',sortable:true}],
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
