<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/shop/Hiiops_Shop_Store_Seckill.js此处编写
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
    import extend from "@/extension/shop/Hiiops_Shop_Store_Seckill.js";
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
                    cnName: '秒杀商品',
                    name: 'Hiiops_Shop_Store_Seckill',
                    url: "/Hiiops_Shop_Store_Seckill/",
                    sortName: "Id"
                },
                extend: extend,
                editFormFileds: {},
                editFormOptions: [],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'商品秒杀商品表Id',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Product_Id',title:'商品Id',type:'int',width:90,require:true,align:'left',sortable:true},
                       {field:'Image',title:'推荐图',type:'string',width:220,require:true,align:'left'},
                       {field:'Images',title:'轮播图',type:'string',width:220,require:true,align:'left'},
                       {field:'Title',title:'活动标题',type:'string',width:220,require:true,align:'left'},
                       {field:'Info',title:'简介',type:'string',width:220,require:true,align:'left'},
                       {field:'Price',title:'价格',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Cost',title:'成本',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Ot_Price',title:'原价',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Give_Integral',title:'返多少积分',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Stock',title:'库存',type:'int',width:90,require:true,align:'left'},
                       {field:'Sales',title:'销量',type:'int',width:90,require:true,align:'left'},
                       {field:'Unit_Name',title:'单位名',type:'string',width:90,require:true,align:'left'},
                       {field:'Postage',title:'邮费',type:'decimal',width:90,require:true,align:'left'},
                       {field:'Description',title:'内容',type:'string',width:90,align:'left'},
                       {field:'Start_Time',title:'开始时间',type:'string',width:220,require:true,align:'left'},
                       {field:'Stop_Time',title:'结束时间',type:'string',width:220,require:true,align:'left'},
                       {field:'Add_Time',title:'添加时间',type:'string',width:220,require:true,align:'left'},
                       {field:'Status',title:'商品状态',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Postage',title:'是否包邮',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Hot',title:'热门推荐',type:'byte',width:90,require:true,align:'left'},
                       {field:'Is_Del',title:'删除 0未删除1已删除',type:'byte',width:90,require:true,align:'left'},
                       {field:'Num',title:'最多秒杀几个',type:'int',width:90,require:true,align:'left'},
                       {field:'Is_Show',title:'显示',type:'byte',width:90,require:true,align:'left'},
                       {field:'Time_Id',title:'时间段Id',type:'int',width:90,align:'left'},
                       {field:'Temp_Id',title:'运费模板Id',type:'int',width:90,align:'left'},
                       {field:'Weight',title:'商品重量',type:'decimal',width:90,align:'left'},
                       {field:'Volume',title:'商品体积',type:'decimal',width:90,align:'left'},
                       {field:'Quota',title:'限购总数',type:'int',width:90,require:true,align:'left'},
                       {field:'Quota_Show',title:'限购总数显示',type:'int',width:90,require:true,align:'left'},
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
