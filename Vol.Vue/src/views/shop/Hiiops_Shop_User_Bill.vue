<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_User_Bill.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_User_Bill.js";
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
                    cnName: '资金记录',
                    name: 'Hiiops_Shop_User_Bill',
                    url: "/Hiiops_Shop_User_Bill/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'用户账单Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'UId',title:'用户uId',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'Link_Id',title:'关联Id',type:'string',width:120,require:true,align:'left'},
                       {field:'Pm',title:'0 = 支出 1 = 获得',type:'byte',width:90,require:true,align:'left'},
                       {field:'Title',title:'账单标题',type:'string',width:180,require:true,align:'left'},
                       {field:'Category',title:'明细种类',type:'string',width:180,require:true,align:'left'},
                       {field:'Type',title:'明细类型',type:'string',width:180,require:true,align:'left'},
                       {field:'Number',title:'明细数字',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Balance',title:'剩余',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Mark',title:'备注',type:'string',width:220,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'0 = 带确定 1 = 有效 -1 = 无效',type:'byte',width:90,require:true,align:'left'},
                       {field:'Take',title:'0 = 未收货 1 = 已收货',type:'byte',width:90,require:true,align:'left'},
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
