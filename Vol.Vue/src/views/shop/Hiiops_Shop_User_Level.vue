<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_User_Level.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_User_Level.js";
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
                    cnName: '会员等级',
                    name: 'Hiiops_Shop_User_Level',
                    url: "/Hiiops_Shop_User_Level/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Discount',title:'享受折扣',type:'int',width:80,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'int',width:80,require:true,align:'left'},
                       {field:'Is_Del',title:'是否删除,0=未删除,1=删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'Remind',title:'是否已通知',type:'byte',width:90,require:true,align:'left'},
                       {field:'Status',title:'0:禁止,1:正常',type:'byte',width:90,require:true,align:'left'},
                       {field:'Mer_Id',title:'商户Id',type:'int',width:80,require:true,align:'left'},
                       {field:'Is_Forever',title:'是否永久',type:'byte',width:90,require:true,align:'left'},
                       {field:'ValId_Time',title:'过期时间',type:'int',width:80,require:true,align:'left'},
                       {field:'Grade',title:'会员等级',type:'int',width:80,require:true,align:'left'},
                       {field:'Level_Id',title:'等级vip',type:'int',width:80,require:true,align:'left'},
                       {field:'UId',title:'用户uId',type:'int',width:80,require:true,align:'left'},
                       {field:'Mark',title:'备注',type:'string',width:220,require:true,align:'left'},
                       {field:'ModifyDate',title:'ModifyDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'Id',title:'等级ID',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'}],
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
