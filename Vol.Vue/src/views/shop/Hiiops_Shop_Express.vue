<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Express.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Express.js";
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
                    cnName: '物流公司',
                    name: 'Hiiops_Shop_Express',
                    url: "/Hiiops_Shop_Express/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'快递公司Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Code',title:'快递公司简称',type:'string',width:120,require:true,align:'left',sortable:true},
                       {field:'Name',title:'快递公司全称',type:'string',width:120,require:true,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Show',title:'是否显示',type:'byte',width:90,require:true,align:'left'},
                       {field:'CreateId',title:'CreateId',type:'int',width:90,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyId',title:'ModifyId',type:'int',width:90,hidden:true,align:'left'},
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
