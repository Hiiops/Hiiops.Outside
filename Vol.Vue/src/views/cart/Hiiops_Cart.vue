<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart.js";
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
                    cnName: '车辆管理',
                    name: 'Hiiops_Cart',
                    url: "/Hiiops_Cart/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFileds: {"Name":"","BrandId":"","CategoryId":"","CoverImage":"","Images":"","DetailContent":"","StaticUrl":"","PV":"","Status":"","Keywords":"","Sort":"","Recomend":"","Hot":"","SetTop":"","SalePrice":"","Price":"","Mileage":"","LicenseTime":"","Sale":"","Remark":""},
                editFormOptions: [[{"title":"名称","required":true,"field":"Name","type":"text"},
                               {"dataKey":"cartbrand","title":"品牌","required":true,"field":"BrandId","type":"select"},
                               {"dataKey":"cartcategory","title":"分类","required":true,"field":"CategoryId","type":"select"}],
                              [{"title":"封面","field":"CoverImage","type":"img"}],
                              [{"title":"主图","field":"Images","type":"img"}],
                              [{"title":"详情","field":"DetailContent","disabled":true,"type":"textarea"}],
                              [{"title":"关键字","field":"Keywords"},
                               {"title":"静态页面","field":"StaticUrl"},
                               {"title":"浏览数","required":true,"field":"PV","type":"number"},
                               {"dataKey":"status","title":"启用状态","required":true,"field":"Status","type":"select"}],
                              [{"title":"排序","required":true,"field":"Sort","type":"number"},
                               {"title":"推荐","field":"Recomend","type":"switch"},
                               {"title":"热门","field":"Hot","type":"switch"}],
                              [{"title":"置顶","field":"SetTop","type":"switch"},
                               {"title":"促销价格","field":"SalePrice"},
                               {"title":"价格","field":"Price"}],
                              [{"title":"里程","field":"Mileage"},
                               {"title":"上牌时间","field":"LicenseTime","type":"datetime"},
                               {"title":"出售","field":"Sale","type":"switch"}],
                              [{"title":"备注","field":"Remark","type":"textarea"}]],
                searchFormFileds: {"Name":"","BrandId":"","CategoryId":"","Sale":""},
                searchFormOptions: [[{"title":"名称","field":"Name","type":"like"},{"dataKey":"cartbrand","title":"品牌","field":"BrandId","type":"select"}],[{"dataKey":"cartcategory","title":"分类","field":"CategoryId","type":"select"},{"title":"出售","field":"Sale"}]],
                columns: [{field:'Id',title:'主键',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'名称',type:'string',link:true,width:220,require:true,align:'left',sortable:true},
                       {field:'BrandId',title:'品牌',type:'int',bind:{ key:'cartbrand',data:[]},width:90,require:true,align:'left'},
                       {field:'CategoryId',title:'分类',type:'int',bind:{ key:'cartcategory',data:[]},width:90,require:true,align:'left'},
                       {field:'CoverImage',title:'封面',type:'img',width:90,align:'left'},
                       {field:'Images',title:'主图',type:'img',width:220,align:'left'},
                       {field:'DetailContent',title:'详情',type:'string ',width:90,readonly:true,align:'left'},
                       {field:'StaticUrl',title:'静态页面',type:'string',width:220,align:'left'},
                       {field:'PV',title:'浏览数',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'启用状态',type:'int',bind:{ key:'status',data:[]},width:90,require:true,align:'left'},
                       {field:'Keywords',title:'关键字',type:'string',width:220,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,require:true,align:'left'},
                       {field:'Recomend',title:'推荐',type:'bool',width:90,align:'left'},
                       {field:'Hot',title:'热门',type:'bool',width:90,align:'left'},
                       {field:'SetTop',title:'置顶',type:'bool',width:90,align:'left'},
                       {field:'SalePrice',title:'促销价格',type:'string',width:220,align:'left'},
                       {field:'Price',title:'价格',type:'string',width:220,align:'left'},
                       {field:'Mileage',title:'里程',type:'string',width:220,align:'left'},
                       {field:'LicenseTime',title:'上牌时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'Sale',title:'出售',type:'bool',width:90,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'上传人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'上传人',type:'string',width:130,align:'left'},
                       {field:'CreateDate',title:'添加时间',type:'datetime',width:90,align:'left',sortable:true},
                       {field:'ModifyID',title:'修改人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Modifier',title:'修改人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'ModifyDate',title:'修改时间',type:'datetime',width:90,hidden:true,align:'left',sortable:true}],
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
