<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Combination.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Combination.js";
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
                    cnName: '开团商品',
                    name: 'Hiiops_Shop_Store_Combination',
                    url: "/Hiiops_Shop_Store_Combination/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:80,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Stop_Time',title:'拼团结束时间',type:'int',width:80,require:true,align:'left',sortable:true},
                       {field:'Effective_Time',title:'拼团订单有效时间',type:'int',width:80,require:true,align:'left'},
                       {field:'Cost',title:'拼图商品成本',type:'int',width:80,require:true,align:'left'},
                       {field:'Browse',title:'浏览量',type:'int',width:80,align:'left'},
                       {field:'Unit_Name',title:'单位名',type:'string',width:120,require:true,align:'left'},
                       {field:'Temp_Id',title:'运费模板Id',type:'int',width:80,align:'left'},
                       {field:'Weight',title:'重量',type:'decimal',width:90,align:'left'},
                       {field:'Volume',title:'体积',type:'decimal',width:90,align:'left'},
                       {field:'Num',title:'单次购买数量',type:'int',width:80,align:'left'},
                       {field:'Quota',title:'限购总数',type:'int',width:80,require:true,align:'left'},
                       {field:'Quota_Show',title:'限量总数显示',type:'int',width:80,require:true,align:'left'},
                       {field:'CreateID',title:'CreateID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'Creator',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'CreateDate',type:'datetime',width:150,align:'left',sortable:true},
                       {field:'ModifyID',title:'ModifyID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Start_Time',title:'拼团开始时间',type:'int',width:80,require:true,align:'left'},
                       {field:'Modifier',title:'Modifier',type:'string',width:130,align:'left'},
                       {field:'Postage',title:'邮费',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Mer_Use',title:'商户是否可用1可用0不可用',type:'byte',width:90,align:'left'},
                       {field:'Product_Id',title:'商品Id',type:'int',width:80,require:true,align:'left'},
                       {field:'Mer_Id',title:'商户Id',type:'int',width:80,align:'left'},
                       {field:'Image',title:'推荐图',type:'string',width:220,require:true,align:'left'},
                       {field:'Images',title:'轮播图',type:'string',width:220,require:true,align:'left'},
                       {field:'Title',title:'活动标题',type:'string',width:220,require:true,align:'left'},
                       {field:'Attr',title:'活动属性',type:'string',width:220,align:'left'},
                       {field:'People',title:'参团人数',type:'int',width:80,require:true,align:'left'},
                       {field:'Info',title:'简介',type:'string',width:220,require:true,align:'left'},
                       {field:'Price',title:'价格',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:80,require:true,align:'left'},
                       {field:'Sales',title:'销量',type:'int',width:80,require:true,align:'left'},
                       {field:'Stock',title:'库存',type:'int',width:80,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'string',width:220,require:true,align:'left'},
                       {field:'Is_Host',title:'推荐',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Show',title:'商品状态',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Postage',title:'是否包邮1是0否',type:'byte',width:90,require:true,align:'left'},
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
