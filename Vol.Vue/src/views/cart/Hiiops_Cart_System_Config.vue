<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_System_Config.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart_System_Config.js";
    import ViewGrid from "@/components/basic/ViewGrid.vue";
    var vueParam = {
        components: {
            ViewGrid
        },
        data() {
            return {
                table: {
                    key: 'Config_Id',
                    footer: "Foots",
                    cnName: '参数配置',
                    name: 'Hiiops_Cart_System_Config',
                    url: "/Hiiops_Cart_System_Config/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFileds: {"VAL":"","ConfigType":"","Sta":"","SecretType":"","Secret":"","Remark":"","KEYNAME":""},
                editFormOptions: [[{"title":"值","field":"VAL"},
                               {"dataKey":"config","title":"配置类型","required":true,"field":"ConfigType","type":"select"},
                               {"dataKey":"status","title":"状态","field":"Sta","type":"select"},
                               {"dataKey":"secret","title":"加密类型","field":"SecretType","type":"select"}],
                              [{"title":"秘钥","field":"Secret"},
                               {"title":"备注","field":"Remark"}],
                              [{"title":"名称","field":"KEYNAME"}]],
                searchFormFileds: {"KEYNAME":""},
                searchFormOptions: [[{"title":"名称","field":"KEYNAME","type":"like"}]],
                columns: [{field:'KEYNAME',title:'名称',type:'string',link:true,width:90,align:'left',sortable:true},
                       {field:'Config_Id',title:'主键',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'VAL',title:'值',type:'string',width:90,align:'left'},
                       {field:'ConfigType',title:'配置类型',type:'int',bind:{ key:'config',data:[]},width:80,require:true,align:'left'},
                       {field:'Sta',title:'状态',type:'int',bind:{ key:'status',data:[]},width:80,align:'left'},
                       {field:'SecretType',title:'加密类型',type:'int',bind:{ key:'secret',data:[]},width:80,align:'left'},
                       {field:'Secret',title:'秘钥',type:'string',width:220,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'创建ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'添加人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'创建时间',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,align:'left'},
                       {field:'ModifyDate',title:'修改日期',type:'datetime',width:150,align:'left',sortable:true}],
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
