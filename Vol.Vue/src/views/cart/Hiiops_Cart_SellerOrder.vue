<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_SellerOrder.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart_SellerOrder.js";
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
                    cnName: '销售咨询',
                    name: 'Hiiops_Cart_SellerOrder',
                    url: "/Hiiops_Cart_SellerOrder/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'SellerUserId',title:'用户ID',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'SellerName',title:'名称',type:'string ',width:180,align:'left'},
                       {field:'CartId',title:'车辆ID',type:'int',width:90,align:'left'},
                       {field:'CartName',title:'车名',type:'string ',width:220,align:'left'},
                       {field:'Status',title:'状态',type:'int',width:90,require:true,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:90,align:'left'},
                       {field:'Reply',title:'回复',type:'string',width:90,align:'left'},
                       {field:'CreateID',title:'创建者ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'创建者',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改者ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'OpenId',title:'OpenId',type:'string',width:220,align:'left'},
                       {field:'NickName',title:'昵称',type:'string',width:220,align:'left'},
                       {field:'Phone',title:'联系电话',type:'string',width:90,align:'left'}],
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
