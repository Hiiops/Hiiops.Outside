<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Service.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Service.js";
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
                    cnName: '客服设置',
                    name: 'Hiiops_Shop_Store_Service',
                    url: "/Hiiops_Shop_Store_Service/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'客服Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Mer_Id',title:'商户Id',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'UId',title:'客服uId',type:'int',width:90,require:true,align:'left'},
                       {field:'Avatar',title:'客服头像',type:'string',width:220,require:true,align:'left'},
                       {field:'Nickname',title:'代理名称',type:'string',width:120,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'0隐藏1显示',type:'byte',width:90,require:true,align:'left'},
                       {field:'Notify',title:'订单通知1开启0关闭',type:'int',width:90,align:'left'},
                       {field:'Customer',title:'是否展示统计管理',type:'byte',width:90,require:true,align:'left'},
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
