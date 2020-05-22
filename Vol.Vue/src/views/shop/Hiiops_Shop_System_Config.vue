<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_System_Config.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_System_Config.js";
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
                    cnName: '商城参数',
                    name: 'Hiiops_Shop_System_Config',
                    url: "/Hiiops_Shop_System_Config/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'配置Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Menu_Name',title:'字段名称',type:'string',width:220,require:true,align:'left',sortable:true},
                       {field:'Type',title:'类型(文本框,单选按钮...)',type:'string',width:220,require:true,align:'left'},
                       {field:'Input_Type',title:'表单类型',type:'string',width:90,align:'left'},
                       {field:'Config_Tab_Id',title:'配置分类Id',type:'int',width:90,require:true,align:'left'},
                       {field:'Parameter',title:'规则 单选框和多选框',type:'string',width:220,align:'left'},
                       {field:'Upload_Type',title:'上传文件格式1单图2多图3文件',type:'byte',width:90,align:'left'},
                       {field:'Required',title:'规则',type:'string',width:220,align:'left'},
                       {field:'WIdth',title:'多行文本框的宽度',type:'int',width:90,align:'left'},
                       {field:'High',title:'多行文框的高度',type:'int',width:90,align:'left'},
                       {field:'Value',title:'默认值',type:'string',width:90,align:'left'},
                       {field:'Info',title:'配置名称',type:'string',width:220,require:true,align:'left'},
                       {field:'Desc',title:'配置简介',type:'string',width:220,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'是否隐藏',type:'byte',width:90,require:true,align:'left'},
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
