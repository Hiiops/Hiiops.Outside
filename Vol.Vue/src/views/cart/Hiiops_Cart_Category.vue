<!--
*Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *业务请在@/extension/cart/Hiiops_Cart_Category.js此处编写
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
    import extend from "@/extension/cart/Hiiops_Cart_Category.js";
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
                    cnName: '分类管理',
                    name: 'Hiiops_Cart_Category',
                    url: "/Hiiops_Cart_Category/",
                    sortName: "CreateDate"
                },
                extend: extend,
                editFormFileds: {"Name":"","ParentId":"","PV":"","CoverImage":"","Status":"","Keywords":"","Sort":"","Recomend":"","Hot":"","SetTop":"","Remark":""},
                editFormOptions: [[{"dataKey":"cartcategoryone","title":"父级","field":"ParentId","type":"select"},
                               {"title":"分类","required":true,"field":"Name"},
                               {"title":"浏览","required":true,"field":"PV","type":"number"}],
                              [{"title":"封面","field":"CoverImage","type":"img"}],
                              [{"dataKey":"status","title":"状态","required":true,"field":"Status","type":"select"},
                               {"title":"关键字","field":"Keywords"},
                               {"title":"排序","field":"Sort","type":"number"}],
                              [{"title":"推荐","field":"Recomend","type":"switch"},
                               {"title":"热门","field":"Hot","type":"switch"},
                               {"title":"置顶","field":"SetTop","type":"switch"}],
                              [{"title":"备注","field":"Remark","type":"textarea"}]],
                searchFormFileds: {},
                searchFormOptions: [],
                columns: [{field:'Id',title:'主键',type:'int',width:90,hidden:true,readonly:true,require:true,align:'left'},
                       {field:'Name',title:'分类',type:'string',link:true,width:220,require:true,align:'left',sortable:true},
                       {field:'ParentId',title:'父级',type:'int',bind:{ key:'cartcategoryone',data:[]},width:90,align:'left'},
                       {field:'CoverImage',title:'封面',type:'img',width:90,align:'left'},
                       {field:'PV',title:'浏览',type:'int',width:90,require:true,align:'left'},
                       {field:'Status',title:'状态',type:'int',bind:{ key:'status',data:[]},width:90,require:true,align:'left'},
                       {field:'Keywords',title:'关键字',type:'string',width:220,align:'left'},
                       {field:'Sort',title:'排序',type:'int',width:90,align:'left'},
                       {field:'Recomend',title:'推荐',type:'bool',width:90,align:'left'},
                       {field:'Hot',title:'热门',type:'bool',width:90,align:'left'},
                       {field:'SetTop',title:'置顶',type:'bool',width:90,align:'left'},
                       {field:'Remark',title:'备注',type:'string',width:220,align:'left'},
                       {field:'CreateID',title:'添加人ID',type:'int',width:80,hidden:true,align:'left'},
                       {field:'Creator',title:'添加人',type:'string',width:130,hidden:true,align:'left'},
                       {field:'CreateDate',title:'添加时间',type:'datetime',width:90,hidden:true,align:'left',sortable:true},
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
